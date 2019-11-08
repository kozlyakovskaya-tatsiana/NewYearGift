using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.Sweets
{
    public enum Manufacturer
    {
        Spartak=1,
        Kommunarka,
        Sloduch,
        Vitba
    }
    public abstract class Sweet
    {
        public string Name { get; protected set; }

        public Manufacturer Manufacturer { get; protected set; }

        public double WeightSingleItemInGrams { get; protected set; }

        public double GramsOfSugarSingleItem { get; protected set;}

        public Sweet()
        {

        }

        protected void SetSweet(string name, Manufacturer manufacturer, double weightSingleItemInGrams, double gramsOfSugarSingleItem)
        {
            Name = name;
            Manufacturer = manufacturer;
            WeightSingleItemInGrams = weightSingleItemInGrams;
            GramsOfSugarSingleItem = gramsOfSugarSingleItem;
        }

       /* public Sweet(string name, Manufacturer manufacturer, double weightSingleItemInGrams, double gramsOfSugarSingleItem)
        {
            Name = name;
            Manufacturer = manufacturer;
            WeightSingleItemInGrams = weightSingleItemInGrams;
            GramsOfSugarSingleItem = gramsOfSugarSingleItem;
        }*/

       
        
       /* public override string ToString()
        {
            return String.Format("{0,-9}{1,8:f2} grams {2,8:f2} grams of sugar",Name, WeightSingleItemInGrams, GramsOfSugarSingleItem);

        }*/
    }
}
