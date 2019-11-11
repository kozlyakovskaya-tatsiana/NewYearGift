using System;
using NewYearGift.Sweets;
using System.Linq;
using System.Collections.Generic;
using NewYearGift.Sweets.SweetImplement;
using NewYearGift.SweetGiftModel;
using NewYearGift.SweetGiftModel.SweetGiftImplement;

namespace NewYearGift
{
    class Program
    {
        static void Main(string[] args)
        {
            SweetGift sweetGift = new SweetGift();
            sweetGift.AddSweets(new Marshmallow(KindMarshmallow.Premium));
            sweetGift.AddSweets(new Candy(KindCandy.Snickers), 2);
            sweetGift.AddSweets(new Marshmallow(KindMarshmallow.Bobruisk));
            sweetGift.AddSweets(new Candy(KindCandy.Alenka));
            sweetGift.AddSweets(new Candy(KindCandy.Alenka));
            sweetGift.AddSweets(new Candy(KindCandy.BeeMaya));
            sweetGift.AddSweets(new Waffle(KindWaffle.Yashkino), 3);
            Console.WriteLine(sweetGift);
            sweetGift.Sort(SortCriterion.NameSweet);
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine(sweetGift);
        }
    }
}
