using System;
using System.Collections.Generic;
using System.Text;

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
   sealed public class Waffle:Sweet
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
                    default:
                        return FillingWaffle.Vanilia;
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
                    default:
                        return "VICTORIA";
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
                    default:
                        return Manufacturer.Spartak;
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
                        return 145;
                    case KindWaffle.Yashkino:
                        return 200;
                    default:
                        return 100;
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
                    default:
                        return 33.4;
                }
            }
        }

        public Waffle(KindWaffle kindWaffle):base()
        {
            KindWaffle = kindWaffle;
        }

        public override string ToString()
        {
            return String.Format("{0,-17}","Waffle") + base.ToString() + String.Format("filling: {0}", FillingWaffle);
        }
    }
}
