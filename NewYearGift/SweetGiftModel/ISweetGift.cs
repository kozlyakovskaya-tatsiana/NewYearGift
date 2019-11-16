using NewYearGift.Sweets;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.SweetGiftModel
{
    public interface ISweetGift : IEnumerable<Sweet>
    {
        void AddSweets(Sweet sweet, int numbserSweets);
        void AddSweets(params Sweet[] sweets);
        void RemoveAllSweets();
        double Weight { get; }//in Grams
        double GramsOfSugar { get; }//in Grams
    }
}
