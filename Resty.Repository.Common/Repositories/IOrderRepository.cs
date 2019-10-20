using Resty.Common;
using Resty.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Resty.Repository.Common.Repositories
{
    public interface IOrderRepository : IBaseRepository<Order, GenericFilter>
    {
        #region Methods

        Task<IList<Order>> GetAllOrdersWithFoods();

        #endregion Methods
    }
}