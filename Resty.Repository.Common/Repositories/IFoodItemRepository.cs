using Resty.Common;
using Resty.Model.Models;

namespace Resty.Repository.Common.Repositories
{
    public interface IFoodItemRepository : IBaseRepository<FoodItem, GenericFilter>
    {
    }
}