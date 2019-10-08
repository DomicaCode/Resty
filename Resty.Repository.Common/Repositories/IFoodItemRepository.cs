using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Resty.Common.FilterParameters;
using Resty.Model.Models;

namespace Resty.Repository.Common.Repositories
{
    public interface IFoodItemRepository
    {
        Task<IList<FoodItem>> GetAllFoodItemsAsync();

        Task<bool> AddFoodItemAsync(FoodItem model);

        Task<FoodItem> GetFoodItemAsync(IFoodItemFilterParameters filter);

        Task<bool> DeleteFoodItemAsync(Guid foodId);
    }
}