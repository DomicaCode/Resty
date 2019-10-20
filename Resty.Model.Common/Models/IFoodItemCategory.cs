namespace Resty.Model.Common.Models
{
    public interface IFoodItemCategory : IBaseModel
    {
        #region Properties

        bool IsEnabled { get; set; }
        string Name { get; set; }
        int SortOrder { get; set; }

        #endregion Properties
    }
}