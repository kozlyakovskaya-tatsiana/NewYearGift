using NewYearGift.Sweets;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NewYearGift.SweetGiftModel.SweetGiftComparers
{
    public class SugarSweetInGiftComparer : IComparer<Sweet>
    {
        public int Compare(Sweet x, Sweet y)
        {
            return x.GramsOfSugarSingleItem.CompareTo(y.GramsOfSugarSingleItem);
        }
    }
}
