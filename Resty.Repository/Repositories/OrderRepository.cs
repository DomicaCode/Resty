using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Resty.Common;
using Resty.DAL.DBContext;
using Resty.Model.Models;
using Resty.Repository.Common.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Resty.Repository.Repositories
{
    public class OrderRepository : BaseRepository<Order, GenericFilter>, IOrderRepository
    {
        #region Constructors

        public OrderRepository(
            RestyContext context,
            IMapper mapper) : base(context, mapper)
        {
            Context = context;
        }

        #endregion Constructors

        #region Properties

        private RestyContext Context { get; }

        #endregion Properties

        #region Methods

        public async Task<IList<Order>> GetAllOrdersWithFoods()
        {
            return await Context.Order.Include(c => c.FoodItem).ToListAsync();
        }

        #endregion Methods
    }
}