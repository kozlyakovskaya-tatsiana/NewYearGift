using System;

namespace NewYearGift.Sweets.SweetImplement
{
    public enum KindWaffle
    {
        Vitosha,
        Yashkino,
        Victoria
    }

    public enum FillingWaffle
    {
        Vanilia,
        Chocolate,
        Nut
    }
    public sealed class Waffle : Sweet
    {
        public KindWaffle KindWaffle { get; private set; }

        public FillingWaffle FillingWaffle
        {
            get
            {
                switch (KindWaffle)
                {
                    case KindWaffle.Vitosha:
                        return FillingWaffle.Nut;
                    case KindWaffle.Yashkino:
                        return FillingWaffle.Chocolate;
                    case KindWaffle.Victoria:
                        return FillingWaffle.Vanilia;
                    default:
                        throw new Exception("There is no such kind of waffle");

                }
            }
        }

        public override string Name
        {
            get
            {
                switch (KindWaffle)
                {
                    case KindWaffle.Vitosha:
                        return "ViToSha";
                    case KindWaffle.Yashkino:
                        return "Yashkino waffles";
                    case KindWaffle.Victoria:
                        return "VICTORIA";
                    default:
                        throw new Exception("There is no such kind of waffle");
                }
            }
        }

        public override Manufacturer Manufacturer
        {
            get
            {
                switch (KindWaffle)
                {
                    case KindWaffle.Vitosha:
                        return Manufacturer.Vitba;
                    case KindWaffle.Yashkino:
                        return Manufacturer.Sloduch;
                    case KindWaffle.Victoria:
                        return Manufacturer.Spartak;
                    default:
                        throw new Exception("There is no such kind of waffle");
                }
            }
        }

        public override double WeightSingleItemInGrams
        {
            get
            {
                switch (KindWaffle)
                {
                    case KindWaffle.Vitosha:
                        return 145d;
                    case KindWaffle.Yashkino:
                        return 200d;
                    case KindWaffle.Victoria:
                        return 100d;
                    default:
                        throw new Exception("There is no such kind of waffle");
                }
            }
        }

        public override double GramsOfSugarSingleItem
        {
            get
            {
                switch (KindWaffle)
                {
                    case KindWaffle.Vitosha:
                        return 43.5;
                    case KindWaffle.Yashkino:
                        return 56.9;
                    case KindWaffle.Victoria:
                        return 33.4;
                    default:
                        throw new Exception("There is no such kind of waffle");
                }
            }
        }

        public Waffle(KindWaffle kindWaffle)
        {
            KindWaffle = kindWaffle;
        }

        public override string ToString()
        {
            return String.Format("{0,-17}", "Waffle") + base.ToString() + String.Format("filling: {0}", FillingWaffle);
        }
    }
}
