using NewYearGift.SweetGiftModel;
using NewYearGift.SweetGiftModel.SweetGiftImplement;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NewYearGift.WorkConsoleForSweetGift
{
    public static class SweetGiftConsole
    {
        public static void StartWorking(SweetGift sweetGift)
        {
            if (sweetGift == null) throw new Exception("Gift does not references to anything");
            do
            {
                Console.Clear();
                Console.WriteLine(
               "Choose the item\n" +
               "1.Information about gift\n" +
               "2.Sort sweets in the gift by name\n" +
               "3.Sort sweets in the gift by weight\n" +
               "4.Sort sweets in the gift by sugar\n" +
               "5.Find the candy in the gift corresponding to the specified range of sugar content\n" +
               "Press any key to finish work"
               );
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine(sweetGift);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        sweetGift.Sort(SortCriterion.NameSweet);
                        Console.WriteLine(sweetGift);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        sweetGift.Sort(SortCriterion.WeightSweet);
                        Console.WriteLine(sweetGift);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        sweetGift.Sort(SortCriterion.SugarSweet);
                        Console.WriteLine(sweetGift);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Enter the left limit: ");
                        if (!(double.TryParse(Console.ReadLine(), out double leftLimit)))
                            throw new Exception("Incorrect input of the left limit");
                        Console.WriteLine("Enter the right limit: ");
                        if (!(double.TryParse(Console.ReadLine(), out double rightLimit)))
                            throw new Exception("Incorrect input of the right limit");
                        if (sweetGift.SearchSweetBySugar(leftLimit, rightLimit).Count == 0)
                            Console.WriteLine("There are no such sweets in the gift");
                        else
                            Console.WriteLine(new SweetGift(sweetGift.SearchSweetBySugar(leftLimit, rightLimit)));
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
