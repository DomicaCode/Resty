using Resty.Common;
using Resty.Model.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Resty.Service.Common.Services
{
    public interface IFoodItemService
    {
        #region Methods

        Task<bool> AddFoodItemAsync(FoodItem model);

        Task<bool> DeleteFoodItemAsync(Guid foodId);

        Task<bool> EditFoodItemAsync(FoodItem model);

        Task<IList<FoodItem>> GetAllFoodItemsAsync();

        Task<FoodItem> GetFoodItemAsync(GenericFilter filter);

        #endregion Methods
    }
}