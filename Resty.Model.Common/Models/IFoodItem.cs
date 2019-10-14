using System;

namespace Resty.Model.Common.Models
{
    public interface IFoodItem : IBaseModel
    {
        #region Properties

        string Description { get; set; }

        Guid FoodItemCategoryId { get; set; }

        string Ingredients { get; set; }

        bool IsEnabled { get; set; }

        decimal Price { get; set; }

        int SortOrder { get; set; }

        #endregion Properties
    }
}