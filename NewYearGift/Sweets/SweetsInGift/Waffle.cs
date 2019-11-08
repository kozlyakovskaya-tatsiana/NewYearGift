using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.Sweets.SweetsInGift
{
    public enum TypeWaffle
    {
        Vanilia=1,
        Chocolate,
        Nut
    }
    sealed public class Waffle:Sweet
    {
        public TypeWaffle TypeWaffle { get; private set; }

        public Waffle (string name, double weightSingleItemInGrams, double gramsOfSugarSingleItem, TypeWaffle typeWaffle) :
           base(name, weightSingleItemInGrams, gramsOfSugarSingleItem)
        {
            TypeWaffle = typeWaffle;
        }
    }
}
