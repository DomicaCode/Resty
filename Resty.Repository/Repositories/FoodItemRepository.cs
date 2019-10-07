using Microsoft.EntityFrameworkCore;
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
        public FoodItemRepository(RestyContext restyContext)
        {
            RestyContext = restyContext;
        }

        public RestyContext RestyContext { get; }

        public async Task<IList<FoodItem>> GetAllFoodItemsAsync()
        {
            return await RestyContext.FoodItem.ToListAsync();
        }

        public async Task AddFoodItemAsync(FoodItem model)
        {
            var test =  await RestyContext.FoodItem.AddAsync(model);
            await RestyContext.SaveChangesAsync();
        }
    }
}
