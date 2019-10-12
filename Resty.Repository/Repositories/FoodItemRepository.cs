using AutoMapper;
using Resty.Common;
using Resty.DAL;
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
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(context, unitOfWork, mapper)
        {
        }

        #endregion Constructors
    }
}