using Microsoft.EntityFrameworkCore;
using Resty.Common;
using Resty.Common.FilterParameters;
using Resty.DAL.DBContext;
using Resty.Model.Models;
using Resty.Repository.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Resty.Repository.Repositories
{
    public class FoodItemRepository : IFoodItemRepository
    {
        public FoodItemRepository(RestyContext restyContext, IFilterFacade filterFacade)
        {
            RestyContext = restyContext;
            FilterFacade = filterFacade;
        }

        public RestyContext RestyContext { get; }
        public IFilterFacade FilterFacade { get; }

        public async Task<IList<FoodItem>> GetAllFoodItemsAsync()
        {
            return await RestyContext.FoodItem.ToListAsync();
        }

        public async Task<bool> AddFoodItemAsync(FoodItem model)
        {
            var result =  await RestyContext.FoodItem.AddAsync(model);
            if (result.State == EntityState.Added)
            {
                await RestyContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<FoodItem> GetFoodItemAsync(IFoodItemFilterParameters filter)
        {
            return await FilterFoodItem(filter);
        }

        public async Task<bool> DeleteFoodItemAsync(Guid foodId)
        {
            if (foodId != null && foodId != Guid.Empty)
            {
                var filter = FilterFacade.Get<IFoodItemFilterParameters>();
                filter.Id = foodId;

                var foodItemToRemove = await GetFoodItemAsync(filter);

                if (foodItemToRemove != null)
                {
                    var result = RestyContext.FoodItem.Remove(foodItemToRemove);

                    if (result.State == EntityState.Deleted)
                    {
                        await RestyContext.SaveChangesAsync();
                        return true;
                    }
                }
            }

            return false;
           
        }

        private async Task<FoodItem> FilterFoodItem(IFoodItemFilterParameters filter)
        {
            var context = RestyContext.FoodItem.AsNoTracking();

            if (filter.Id != null)
            {
                return await context.FirstOrDefaultAsync(x => x.Id == filter.Id);
            }
            else if (!string.IsNullOrWhiteSpace(filter.Name))
            {
                return await context.FirstOrDefaultAsync(x => x.Name == filter.Name);
            }
            else if (filter.Price != null)
            {
                return await context.FirstOrDefaultAsync(x => x.Price == filter.Price);
            }

            return null;
        }
    }
}
