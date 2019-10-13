namespace Resty.Common.FilterParameters
{
    public interface IFoodItemFilterParameters : IGenericFilter

    {
        #region Properties

        decimal? Price { get; set; }

        #endregion Properties
    }
}