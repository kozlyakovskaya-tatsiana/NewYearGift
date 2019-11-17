using System;

namespace NewYearGift.Sweets.SweetImplement
{
    public enum KindCandy
    {
        Alenka,
        Snickers,
        Malibu,
        Kapri,
        BeeMaya
    }

    public enum FillingCandy
    {
        Chocolate,
        Caramel,
        Jelly
    }

    public sealed class Candy : Sweet
    {
        public KindCandy KindCandy { get; private set; }

        public FillingCandy FillingCandy
        {
            get
            {
                switch (KindCandy)
                {
                    case KindCandy.Alenka:
                        return FillingCandy.Chocolate;
                    case KindCandy.BeeMaya:
                        return FillingCandy.Jelly;
                    case KindCandy.Kapri:
                        return FillingCandy.Caramel;
                    case KindCandy.Malibu:
                        return FillingCandy.Caramel;
                    case KindCandy.Snickers:
                        return FillingCandy.Chocolate;
                    default:
                        throw new Exception("There is no such Candy");
                }

            }
        }

        public override string Name
        {
            get
            {
                switch (KindCandy)
                {
                    case KindCandy.Alenka:
                        return "Alenka Classic";
                    case KindCandy.BeeMaya:
                        return "Bee Maya";
                    case KindCandy.Kapri:
                        return "Kapri New";
                    case KindCandy.Malibu:
                        return "Malibuuu";
                    case KindCandy.Snickers:
                        return "SNICKERS";
                    default:
                        throw new Exception("There is no such Candy");
                }
            }
        }

        public override Manufacturer Manufacturer
        {
            get
            {
                switch (KindCandy)
                {
                    case KindCandy.Alenka:
                        return Manufacturer.Kommunarka;
                    case KindCandy.BeeMaya:
                        return Manufacturer.Spartak;
                    case KindCandy.Kapri:
                        return Manufacturer.Sloduch;
                    case KindCandy.Malibu:
                        return Manufacturer.Sloduch;
                    case KindCandy.Snickers:
                        return Manufacturer.Spartak;
                    default:
                        throw new Exception("There is no such Candy");
                }
            }
        }

        public override double WeightSingleItemInGrams
        {
            get
            {
                switch (KindCandy)
                {
                    case KindCandy.Alenka:
                        return 95d;
                    case KindCandy.BeeMaya:
                        return 15.6;
                    case KindCandy.Kapri:
                        return 12.7;
                    case KindCandy.Malibu:
                        return 11.9;
                    case KindCandy.Snickers:
                        return 85d;
                    default:
                        throw new Exception("There is no such Candy");
                }
            }
        }

        public override double GramsOfSugarSingleItem
        {
            get
            {
                switch (KindCandy)
                {
                    case KindCandy.Alenka:
                        return 28.7;
                    case KindCandy.BeeMaya:
                        return 5.3;
                    case KindCandy.Kapri:
                        return 6.8;
                    case KindCandy.Malibu:
                        return 7.2;
                    case KindCandy.Snickers:
                        return 31.3;
                    default:
                        throw new Exception("There is no such Candy");
                }
            }
        }

        public Candy(KindCandy kindCandy)
        {
            KindCandy = kindCandy;
        }

        public override string ToString()
        {
            return String.Format("{0,-17}", "Candy") + base.ToString() + String.Format("filling: {0}", FillingCandy);
        }
    }
}
