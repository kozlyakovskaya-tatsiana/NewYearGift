using System;
using NewYearGift.Sweets;
using System.Linq;
using System.Collections.Generic;
using NewYearGift.Sweets.SweetImplement;
using NewYearGift.SweetGiftModel;
using NewYearGift.SweetGiftModel.SweetGiftImplement;
using NewYearGift.WorkConsoleForSweetGift;

namespace NewYearGift
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SweetGift sweetGift = new SweetGift();
                sweetGift.AddSweets(new Marshmallow(KindMarshmallow.Premium));
                sweetGift.AddSweets(new Candy(KindCandy.Snickers), 2);
                sweetGift.AddSweets(new Marshmallow(KindMarshmallow.Bobruisk));
                sweetGift.AddSweets(new Candy(KindCandy.Alenka), 2);
                sweetGift.AddSweets(new Waffle(KindWaffle.Victoria));
                sweetGift.AddSweets(new Waffle(KindWaffle.Yashkino), 3);
                SweetGiftConsole.StartWorking(sweetGift);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program have finished");
            }
        }
    }
}
