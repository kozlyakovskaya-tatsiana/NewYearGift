using NewYearGift.Sweets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NewYearGift.SweetGiftModel
{
    public class SweetGift : ISweetGift
    {
        private List<Sweet> SweetsInGift;

        public double Weight
        {
            get
            {
                return SweetsInGift.Sum(u => u.WeightSingleItemInGrams);
            }
        }
        
        public double GramsOfSugar
        {
            get
            {
                return SweetsInGift.Sum(u => u.GramsOfSugarSingleItem);
            }
        }

        public SweetGift()
        {
            SweetsInGift = new List<Sweet>();
        }

        public SweetGift(IEnumerable<Sweet> sweets)
        {
            SweetsInGift = new List<Sweet>(sweets);
        }

        public void AddSweets(Sweet sweet)
        {
            SweetsInGift.Add(sweet);
        }

        public void AddSweets(Sweet sweet, int numbserSweets)
        {
            for (int i = 0; i < numbserSweets; i++) 
                SweetsInGift.Add(sweet);
        }

        public void AddSweets(params Sweet[] sweets)
        {
            SweetsInGift.AddRange(sweets);

        }
        
        public void RemoveAllSweets()
        {
            SweetsInGift.Clear();
        }

        public IEnumerator<Sweet> GetEnumerator()
        {
            foreach (var sweet in SweetsInGift)
                yield return sweet;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
