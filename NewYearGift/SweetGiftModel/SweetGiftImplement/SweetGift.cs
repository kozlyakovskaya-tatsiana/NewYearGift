using NewYearGift.Sweets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NewYearGift.SweetGiftModel;

namespace NewYearGift.SweetGiftModel.SweetGiftImplement
{
    public sealed class SweetGift : ISweetGift, ISortableSweetGift
    {
        private List<Sweet> SweetsInGift;

        public bool IsEmpty
        {
            get
            {
                return SweetsInGift.Count == 0;
            }
        }

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
            if (sweets == null) throw new Exception("The collection of sweets does not references to anything");
            SweetsInGift = new List<Sweet>(sweets);
        }

        public void AddSweets(Sweet sweet, int numbserSweets)
        {
            if (sweet == null) throw new Exception("The sweet does not references to anything");
            SweetsInGift.AddRange(Enumerable.Repeat(sweet, numbserSweets));
        }

        public void AddSweets(params Sweet[] sweets)
        {
            if (sweets == null) throw new Exception("The collection of sweets does not references to anything");
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

        public void Sort(SortCriterion sortCriterion)
        {
            switch (sortCriterion)
            {
                case SortCriterion.WeightSweet:
                    SweetsInGift.Sort((x, y) => x.WeightSingleItemInGrams.CompareTo(y.WeightSingleItemInGrams));
                    break;
                case SortCriterion.SugarSweet:
                    SweetsInGift.Sort((x, y) => x.GramsOfSugarSingleItem.CompareTo(y.GramsOfSugarSingleItem));
                    break;
                case SortCriterion.NameSweet:
                    SweetsInGift.Sort((x, y) => x.Name.CompareTo(y.Name));
                    break;
                default:
                    throw new Exception("This criterion is not available");
            }
        }

        public List<Sweet> SearchSweetBySugar(double leftLimit, double rightLimit)
        {
            return SweetsInGift.Where(sw => sw.GramsOfSugarSingleItem >= leftLimit && sw.GramsOfSugarSingleItem <= rightLimit).ToList();
        }

        public override string ToString()
        {
            if (this.IsEmpty) return "The gift is empty";
            var sweets = SweetsInGift.Select(sw => sw.ToString());
            return String.Join("\n", sweets) + String.Format("\nTotal weight {0:f2} grams\nTotal sugar = {1:f2} grams of sugar", Weight, GramsOfSugar);
        }
    }
}
