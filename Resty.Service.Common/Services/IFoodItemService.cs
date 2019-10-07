using System.Collections.Generic;
using System.Threading.Tasks;
using Resty.Model.Models;

namespace Resty.Service.Common.Services
{
    public interface IFoodItemService
    {
        Task<IList<FoodItem>> GetAllFoodItemsAsync();

        Task AddFoodItemAsync(FoodItem model);
    }
}