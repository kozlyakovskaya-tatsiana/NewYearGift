using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.Sweets.SweetsInGift
{
    public enum TypeCandy
    {
        Chocolate=1,
        Caramel,
        Jelly
    }
    sealed public class  Candy:Sweet
    {
        public TypeCandy TypeCandy { get; private set; }

        public Candy(string name, double weightSingleItemInGrams, double gramsOfSugarSingleItem, TypeCandy typeCandy):
            base(name, weightSingleItemInGrams, gramsOfSugarSingleItem)
        {
            TypeCandy = typeCandy;
        }
    }
}
