using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.SweetGiftModel
{
    public enum SortCriterion
    {
        WeightSweet,
        SugarSweet,
        NameSweet
    }

    public interface ISweetGiftSort
    {
        void Sort(SortCriterion sortCriterion);
    }
}
