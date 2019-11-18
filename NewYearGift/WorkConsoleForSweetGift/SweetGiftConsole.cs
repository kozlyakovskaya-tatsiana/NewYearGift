using NewYearGift.SweetGiftModel;
using NewYearGift.SweetGiftModel.SweetGiftImplement;
using System;

namespace NewYearGift.WorkConsoleForSweetGift
{
    public static class SweetGiftConsole
    {
        #region constants
        private const string header =
                @"Choose the item
                1.Information about gift
                2.Sort sweets in the gift by name
                3.Sort sweets in the gift by weight
                4.Sort sweets in the gift by sugar
                5.Find the candy in the gift corresponding to the specified range of sugar content
                Press another key to finish work";
        #endregion

        public static void StartWorking(SweetGift sweetGift)
        {
            if (sweetGift == null) return;
            do
            {
                Console.Clear();
                Console.WriteLine(header);
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(sweetGift);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "2":
                        sweetGift.Sort(SortCriterion.NameSweet);
                        Console.WriteLine(sweetGift);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "3":
                        sweetGift.Sort(SortCriterion.WeightSweet);
                        Console.WriteLine(sweetGift);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "4":
                        sweetGift.Sort(SortCriterion.SugarSweet);
                        Console.WriteLine(sweetGift);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Enter the left limit: ");
                        if (!(double.TryParse(Console.ReadLine(), out double leftLimit)) || leftLimit < 0)
                        {
                            Console.WriteLine("Incorrect input of the left limit");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Enter the right limit: ");
                        if (!(double.TryParse(Console.ReadLine(), out double rightLimit)) || rightLimit < 0)
                        {
                            Console.WriteLine("Incorrect input of the right limit");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                        }
                        if (leftLimit > rightLimit)
                        {
                            Console.WriteLine("Incorrect input. Left limit must be less or equals than right limit");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine(sweetGift.SearchSweetBySugar(leftLimit, rightLimit).Count == 0 ?
                            "There are no such sweets in the gift" :
                             new SweetGift(sweetGift.SearchSweetBySugar(leftLimit, rightLimit)).ToString());
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("You have finished work");
                        return;
                }
            } while (true);
        }
    }
}
