using NewYearGift.Sweets;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NewYearGift.SweetGiftModel.SweetGiftComparers
{
    public class NameSweetGiftComparer : IComparer<Sweet>
    {
        public int Compare(Sweet x, Sweet y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
