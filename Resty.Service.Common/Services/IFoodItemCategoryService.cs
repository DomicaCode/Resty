using Resty.Common;
using Resty.Model.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Resty.Service.Common.Services
{
    public interface IFoodItemCategoryService
    {
        #region Methods

        Task<bool> AddFoodItemCategoryAsync(FoodItemCategory model);

        Task<bool> DeleteFoodItemCategoryAsync(Guid foodId);

        Task<bool> EditFoodItemCategoryAsync(FoodItemCategory model);

        Task<IList<FoodItemCategory>> GetAllFoodItemCategoriesAsync();

        Task<FoodItemCategory> GetFoodItemCategoryAsync(GenericFilter filter);

        #endregion Methods
    }
}