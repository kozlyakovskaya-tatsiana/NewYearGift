using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.Sweets.SweetsInGift
{
    public enum TypeMarshmallow
    {
        White=1,
        Pink,
        InChocolate
    }
    sealed public class Marshmallow:Sweet
    {
        public TypeMarshmallow TypeMarshmallow { get; private set; }
        public Marshmallow(string name, double weightSingleItemInGrams, double gramsOfSugarSingleItem,TypeMarshmallow typeMarshmallow):
            base(name, weightSingleItemInGrams, gramsOfSugarSingleItem)
        {
            TypeMarshmallow = typeMarshmallow;
        }
    }
}
