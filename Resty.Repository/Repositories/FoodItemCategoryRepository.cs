using AutoMapper;
using Resty.Common;
using Resty.DAL.DBContext;
using Resty.Model.Models;
using Resty.Repository.Common.Repositories;

namespace Resty.Repository.Repositories
{
    public class FoodItemCategoryRepository : BaseRepository<FoodItemCategory, GenericFilter>, IFoodItemCategoryRepository
    {
        #region Constructors

        public FoodItemCategoryRepository(
            RestyContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        #endregion Constructors
    }
}