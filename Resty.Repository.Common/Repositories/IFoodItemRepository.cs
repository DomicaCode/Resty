using System.Collections.Generic;
using System.Threading.Tasks;
using Resty.Model.Models;

namespace Resty.Repository.Common.Repositories
{
    public interface IFoodItemRepository
    {
        Task<IList<FoodItem>> GetAllFoodItemsAsync();
    }
}