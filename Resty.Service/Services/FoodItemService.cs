using Resty.Common.FilterParameters;
using Resty.Model.Models;
using Resty.Repository.Common.Repositories;
using Resty.Service.Common.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Resty.Service.Services
{
    public class FoodItemService : IFoodItemService
    {
        public FoodItemService(IFoodItemRepository foodItemRepository)
        {
            FoodItemRepository = foodItemRepository;
        }

        public IFoodItemRepository FoodItemRepository { get; }

        public async Task<IList<FoodItem>> GetAllFoodItemsAsync()
        {
            return await FoodItemRepository.GetAllFoodItemsAsync();
        }

        public async Task<FoodItem> GetFoodItemAsync(IFoodItemFilterParameters filter)
        {
            return await FoodItemRepository.GetFoodItemAsync(filter);
        }

        public async Task<bool> AddFoodItemAsync(FoodItem model)
        {
            return await FoodItemRepository.AddFoodItemAsync(model);
        }

        public async Task<bool> DeleteFoodItemAsync(Guid foodId)
        {
            return await FoodItemRepository.DeleteFoodItemAsync(foodId);
        }
    }
}
