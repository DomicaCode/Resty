using AutoMapper;
using Resty.Common;
using Resty.DAL.DBContext;
using Resty.Model.Models;
using Resty.Repository.Common.Repositories;

namespace Resty.Repository.Repositories
{
    public class FoodItemRepository : BaseRepository<FoodItem, GenericFilter>, IFoodItemRepository
    {
        #region Constructors

        public FoodItemRepository(
            RestyContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        #endregion Constructors
    }
}