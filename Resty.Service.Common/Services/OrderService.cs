using Resty.Common;
using Resty.Model.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Resty.Service.Common.Services
{
    public interface IOrderService
    {
        #region Methods

        Task<bool> AddOrderAsync(Order model);

        Task<bool> DeleteOrderAsync(Guid orderId);

        Task<bool> EditOrderAsync(Order model);

        Task<IList<Order>> GetAllOrdersAsync();

        Task<IList<Order>> GetAllOrdersWithFoodAsync();

        Task<Order> GetOrderAsync(GenericFilter filter);

        #endregion Methods
    }
}