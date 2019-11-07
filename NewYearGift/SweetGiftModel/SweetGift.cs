using NewYearGift.Sweets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.SweetGiftModel
{
    public class SweetGift:ISweetGift
    {
        IList <Sweet> SweetsInGift;
        public SweetGift()
        {
            SweetsInGift = new List<Sweet>();             
        }
        public SweetGift(IEnumerable<Sweet> sweets)
        {
            SweetsInGift = new List<Sweet>(sweets);
        }
        public double Weight
        {
            get
            {
                double sumWeight = 0;
                foreach (Sweet sweet in SweetsInGift) sumWeight += sweet.WeightSingleItemInGrams;
                return sumWeight;
            }
        }

        public double  GramsOfSugar
        {
            get
            {
                double sumGramsOfSugar = 0;
                foreach (Sweet sweet in SweetsInGift) sumGramsOfSugar += sweet.GramsOfSugarSingleItem;
                return sumGramsOfSugar;
            }
        }
        public void AddSweets(Sweet sweet)
        {
            SweetsInGift.Add(sweet);
        }
        public void AddSweets(Sweet sweet, int numbserSweets)
        {
            for (int i = 0; i < numbserSweets; i++) SweetsInGift.Add(sweet);
        }

        public void AddSweets(IEnumerable<Sweet> sweets)
        {
            foreach (Sweet sweet in sweets) SweetsInGift.Add(sweet);
        }
        public void AddSweets(params Sweet[] sweets)
        {
            foreach (Sweet sweet in sweets) SweetsInGift.Add(sweet);
        }
        public IEnumerator<Sweet> GetEnumerator()
        {
            foreach (Sweet sweet in SweetsInGift)
                yield return sweet;
        }
        public void RemoveAllSweets()
        {
            SweetsInGift.Clear();
        }

    }
}
