using NewYearGift.Sweets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NewYearGift.SweetGiftModel.SweetGiftComparers;

namespace NewYearGift.SweetGiftModel.SweetGiftImplement
{
    public class SweetGift : ISweetGift,ISweetGiftSort
    {
        public List<Sweet> SweetsInGift;

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
            SweetsInGift.AddRange(Enumerable.Repeat(sweet, numbserSweets));
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

        public override string ToString()
        { 
            var sweets = SweetsInGift.Select(sw => sw.ToString());
            return String.Join("\n", sweets) + String.Format("\nTotal weight {0:f2} grams\nTotal sugar = {1:f2} grams of sugar", Weight, GramsOfSugar);
        }

        public void Sort(SortCriterion sortCriterion)
        {
            switch (sortCriterion)
            {
                case SortCriterion.WeightSweet:
                    SweetsInGift.Sort(new WeightSweetInGiftComparer());
                    break;
                case SortCriterion.SugarSweet:
                    SweetsInGift.Sort(new SugarSweetInGiftComparer());
                    break;
                default:
                    SweetsInGift.Sort(new NameSweetGiftComparer());
                    break;
            }
        }
    }
}
