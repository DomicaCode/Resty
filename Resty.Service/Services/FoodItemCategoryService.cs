using Resty.Common;
using Resty.Model.Models;
using Resty.Repository.Common.Repositories;
using Resty.Service.Common.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Resty.Service.Services
{
    public class FoodItemCategoryService : IFoodItemCategoryService
    {
        #region Constructors

        public FoodItemCategoryService(IFoodItemCategoryRepository foodItemCategoryRepository)
        {
            FoodItemCategoryRepository = foodItemCategoryRepository;
        }

        #endregion Constructors

        #region Properties

        private IFoodItemCategoryRepository FoodItemCategoryRepository { get; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Adds Food Item Async
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> AddFoodItemCategoryAsync(FoodItemCategory model)
        {
            return await FoodItemCategoryRepository.InsertAsync(model);
        }

        /// <summary>
        /// Deletes food item async
        /// </summary>
        /// <param name="foodId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteFoodItemCategoryAsync(Guid foodId)
        {
            await FoodItemCategoryRepository.DeleteAsync(foodId);
            return await FoodItemCategoryRepository.DeleteAsync(foodId);
        }

        /// <summary>
        /// Edits food item async
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> EditFoodItemCategoryAsync(FoodItemCategory model)
        {
            return await FoodItemCategoryRepository.EditAsync(model);
        }

        /// <summary>
        /// Gets all food items async
        /// </summary>
        /// <returns></returns>
        public async Task<IList<FoodItemCategory>> GetAllFoodItemCategoriesAsync()
        {
            return await FoodItemCategoryRepository.GetAllAsync();
        }

        /// <summary>
        /// Gets filtered food item async
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<FoodItemCategory> GetFoodItemCategoryAsync(GenericFilter filter)
        {
            return await FoodItemCategoryRepository.GetAsync(filter);
        }

        #endregion Methods
    }
}