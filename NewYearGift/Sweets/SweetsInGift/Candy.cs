using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.Sweets.SweetsInGift
{
   public enum KindCandy
    {
        Alenka=1,
        Snickers,
        Malibu,
        Kapri,
        BeeMaya
    }

    public enum FillingCandy
    {
        Chocolate = 1,
        Caramel,
        Jelly
    }

    sealed public class  Candy:Sweet
    {
        public KindCandy KindCandy { get; private set; }

        public FillingCandy FillingCandy { get; private set; }

        public Candy(KindCandy kindCandy)
        {
            switch (kindCandy)
            {
                case KindCandy.Alenka:
                    SetCandy("Alenka", Manufacturer.Kommunarka, 100, 50.3, KindCandy.Alenka, FillingCandy.Chocolate);
                    break;
                case KindCandy.BeeMaya:
                    SetCandy("BeeMaya", Manufacturer.Spartak, 15, 4.5, KindCandy.BeeMaya, FillingCandy.Jelly);
                    break;
                case KindCandy.Kapri:
                    SetCandy("Kapri", Manufacturer.Sloduch, 12, 4.3, KindCandy.Kapri, FillingCandy.Caramel);
                    break;
                case KindCandy.Malibu:
                    SetCandy("Malibu", Manufacturer.Sloduch, 14, 5.7, KindCandy.Malibu, FillingCandy.Caramel);
                    break;
                case KindCandy.Snickers:
                    SetCandy("Snickers", Manufacturer.Spartak, 85, 45.7, KindCandy.Snickers, FillingCandy.Chocolate);
                    break;

            }
        }

        private void SetCandy(string name,
            Manufacturer manufacturer,
            double weightSingleItemInGrams,
            double gramsOfSugarSingleItem,
            KindCandy kindCandy,
            FillingCandy fillingCandy)
        {
            base.SetSweet(name, manufacturer, weightSingleItemInGrams, gramsOfSugarSingleItem);
            KindCandy = kindCandy;
            FillingCandy = fillingCandy;
        }




    }
}
