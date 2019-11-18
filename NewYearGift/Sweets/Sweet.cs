using System;

namespace NewYearGift.Sweets
{
    public enum Manufacturer
    {
        Spartak,
        Kommunarka,
        Sloduch,
        Vitba
    }

    public abstract class Sweet
    {
        public abstract string Name { get; }

        public abstract Manufacturer Manufacturer { get; }

        public abstract double WeightSingleItemInGrams { get; }

        public abstract double GramsOfSugarSingleItem { get; }

        public override string ToString()
        {
            return String.Format("{0,-20}{1,8:f2} grams {2,8:f2} grams of sugar Manufacturer: {3,-12} ", Name, WeightSingleItemInGrams, GramsOfSugarSingleItem, Manufacturer);
        }
    }
}
