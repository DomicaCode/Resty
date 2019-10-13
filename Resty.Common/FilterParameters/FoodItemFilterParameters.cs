namespace Resty.Common.FilterParameters
{
    public class FoodItemFilterParameters : GenericFilter, IFoodItemFilterParameters
    {
        #region Properties

        public decimal? Price { get; set; }

        #endregion Properties
    }
}