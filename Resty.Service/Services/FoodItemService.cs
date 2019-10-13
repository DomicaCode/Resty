using Resty.Common;
using Resty.Model.Models;
using Resty.Repository.Common.Repositories;
using Resty.Service.Common.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Resty.Service.Services
{
    public class FoodItemService : IFoodItemService
    {
        #region Constructors

        public FoodItemService(IFoodItemRepository foodItemRepository)
        {
            FoodItemRepository = foodItemRepository;
        }

        #endregion Constructors

        #region Properties

        private IFoodItemRepository FoodItemRepository { get; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Adds Food Item Async
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> AddFoodItemAsync(FoodItem model)
        {
            return await FoodItemRepository.InsertAsync(model);
        }

        /// <summary>
        /// Deletes food item async
        /// </summary>
        /// <param name="foodId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteFoodItemAsync(Guid foodId)
        {
            await FoodItemRepository.DeleteAsync(foodId);
            return await FoodItemRepository.DeleteAsync(foodId);
        }

        /// <summary>
        /// Edits food item async
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> EditFoodItemAsync(FoodItem model)
        {
            return await FoodItemRepository.EditAsync(model);
        }

        /// <summary>
        /// Gets all food items async
        /// </summary>
        /// <returns></returns>
        public async Task<IList<FoodItem>> GetAllFoodItemsAsync()
        {
            return await FoodItemRepository.GetAllAsync();
        }

        /// <summary>
        /// Gets filtered food item async
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<FoodItem> GetFoodItemAsync(GenericFilter filter)
        {
            return await FoodItemRepository.GetAsync(filter);
        }

        #endregion Methods
    }
}