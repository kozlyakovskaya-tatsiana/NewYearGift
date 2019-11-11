using System;
using System.Collections.Generic;
using System.Text;

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

    sealed public class Marshmallow:Sweet
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
                    default:
                        return FillingMarshmallow.Pink;
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
                    default:
                        return "ZeFFa";
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
                    default:
                        return Manufacturer.Vitba;
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
                        return 150;
                    case KindMarshmallow.Light:
                        return 125;
                    case KindMarshmallow.Premium:
                        return 195;
                    default:
                        return 170;
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
                    default:
                        return 57.9;
                }
            }
        }

        public Marshmallow(KindMarshmallow kindMarshmallow):base()
        {
            KindMarshmallow = kindMarshmallow;
        }

        public override string ToString()
        {
            return String.Format("{0,-17}", "Marshmallow") + base.ToString() + String.Format("filling: {0}", FillingMarshmallow);
        }

    }
}
