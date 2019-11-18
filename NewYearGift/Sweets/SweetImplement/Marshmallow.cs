using System;

namespace NewYearGift.Sweets.SweetImplement
{
    public enum KindMarshmallow
    {
        Bobruisk,
        Light,
        Premium,
        Zeffa
    }

    public enum FillingMarshmallow
    {
        White,
        Pink,
        InChocolate
    }

    public sealed class Marshmallow : Sweet
    {
        public KindMarshmallow KindMarshmallow { get; private set; }

        public FillingMarshmallow FillingMarshmallow
        {
            get
            {
                switch (KindMarshmallow)
                {
                    case KindMarshmallow.Bobruisk:
                        return FillingMarshmallow.White;
                    case KindMarshmallow.Light:
                        return FillingMarshmallow.Pink;
                    case KindMarshmallow.Premium:
                        return FillingMarshmallow.InChocolate;
                    case KindMarshmallow.Zeffa:
                        return FillingMarshmallow.Pink;
                    default:
                        throw new Exception("There is no such kind of marshmallow");
                }
            }
        }

        public override string Name
        {
            get
            {
                switch (KindMarshmallow)
                {
                    case KindMarshmallow.Bobruisk:
                        return "Bobruisk marshmallow";
                    case KindMarshmallow.Light:
                        return "Light zef";
                    case KindMarshmallow.Premium:
                        return "Premium Zef";
                    case KindMarshmallow.Zeffa:
                        return "ZeFFa";
                    default:
                        throw new Exception("There is no such kind of marshmallow");
                }
            }
        }

        public override Manufacturer Manufacturer
        {
            get
            {
                switch (KindMarshmallow)
                {
                    case KindMarshmallow.Bobruisk:
                        return Manufacturer.Sloduch;
                    case KindMarshmallow.Light:
                        return Manufacturer.Spartak;
                    case KindMarshmallow.Premium:
                        return Manufacturer.Kommunarka;
                    case KindMarshmallow.Zeffa:
                        return Manufacturer.Vitba;
                    default:
                        throw new Exception("There is no such kind of marshmallow");
                }
            }
        }

        public override double WeightSingleItemInGrams
        {
            get
            {
                switch (KindMarshmallow)
                {
                    case KindMarshmallow.Bobruisk:
                        return 150d;
                    case KindMarshmallow.Light:
                        return 125d;
                    case KindMarshmallow.Premium:
                        return 195d;
                    case KindMarshmallow.Zeffa:
                        return 170d;
                    default:
                        throw new Exception("There is no such kind of marshmallow");
                }
            }
        }

        public override double GramsOfSugarSingleItem
        {
            get
            {
                switch (KindMarshmallow)
                {
                    case KindMarshmallow.Bobruisk:
                        return 53.9;
                    case KindMarshmallow.Light:
                        return 46.4;
                    case KindMarshmallow.Premium:
                        return 63.8;
                    case KindMarshmallow.Zeffa:
                        return 57.9;
                    default:
                        throw new Exception("There is no such kind of marshmallow");
                }
            }
        }

        public Marshmallow(KindMarshmallow kindMarshmallow)
        {
            KindMarshmallow = kindMarshmallow;
        }

        public override string ToString()
        {
            return String.Format("{0,-17}", "Marshmallow") + base.ToString() + String.Format("filling: {0}", FillingMarshmallow);
        }

    }
}
