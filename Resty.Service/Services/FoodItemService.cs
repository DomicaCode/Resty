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

        public FoodItemService(IFoodItemRepository foodItemRepository, IFoodItemCategoryRepository foodItemCategoryRepository)
        {
            FoodItemRepository = foodItemRepository;
            FoodItemCategoryRepository = foodItemCategoryRepository;
        }

        #endregion Constructors

        #region Properties

        private IFoodItemRepository FoodItemRepository { get; }
        private IFoodItemCategoryRepository FoodItemCategoryRepository { get; }

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
            return await FoodItemRepository.DeleteAsync(foodId).ConfigureAwait(false);
        }

        /// <summary>
        /// Edits food item async
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> EditFoodItemAsync(FoodItem model)
        {
            return await FoodItemRepository.EditAsync(model).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all food items async
        /// </summary>
        /// <returns></returns>
        public async Task<IList<FoodItem>> GetAllFoodItemsAsync()
        {
            return await FoodItemRepository.GetAllAsync();
        }

        public async Task<IList<FoodItem>> GetAllFoodItemsAsync(string embed = "")
        {

            var foodItems = await FoodItemRepository.GetAllAsync().ConfigureAwait(false);

            if (embed.Equals(nameof(FoodItem.FoodItemCategory)))
            {
                foreach (var foodItem in foodItems)
                {
                    var category = await FoodItemCategoryRepository.GetAsync(new GenericFilter { Id = foodItem.FoodItemCategoryId });

                    if(category is null)
                        continue;

                    foodItem.FoodItemCategory = category;

                }
            }

            return foodItems;
        }

        /// <summary>
        /// Gets filtered food item async
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<FoodItem> GetFoodItemAsync(GenericFilter filter)
        {
            return await FoodItemRepository.GetAsync(filter).ConfigureAwait(false);
        }

        #endregion Methods
    }
}