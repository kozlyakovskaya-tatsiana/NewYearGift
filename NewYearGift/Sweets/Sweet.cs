using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.Sweets
{
    public abstract class Sweet
    {
        public string Name { get; protected set; }

        public double WeightSingleItemInGrams { get; protected set; }

        public double GramsOfSugarSingleItem { get; protected set;}

        protected Sweet (string name, double weightSingleItemInGrams, double gramsOfSugarSingleItem)
        {
            Name = name;
            WeightSingleItemInGrams = weightSingleItemInGrams;
            GramsOfSugarSingleItem = gramsOfSugarSingleItem;
        }

       /* public override string ToString()
        {
            return String.Format("{0,-9}{1,8:f2} grams {2,8:f2} grams of sugar",Name, WeightSingleItemInGrams, GramsOfSugarSingleItem);

        }*/
    }
}
