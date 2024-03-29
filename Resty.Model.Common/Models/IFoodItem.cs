﻿namespace Resty.Model.Common.Models
{
    public interface IFoodItem : IBaseModel
    {
        #region Properties

        string Description { get; set; }
        string Ingredients { get; set; }
        decimal Price { get; set; }

        #endregion Properties
    }
}