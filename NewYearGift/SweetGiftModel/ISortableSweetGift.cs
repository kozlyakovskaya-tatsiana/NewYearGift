namespace NewYearGift.SweetGiftModel
{
    public enum SortCriterion
    {
        WeightSweet,
        SugarSweet,
        NameSweet
    }

    public interface ISortableSweetGift
    {
        void Sort(SortCriterion sortCriterion);
    }
}
