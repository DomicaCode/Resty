using Resty.Common;
using Resty.Model.Models;
using Resty.Repository.Common.Repositories;
using Resty.Service.Common.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Resty.Service.Services
{
    public class OrderService : IOrderService
    {
        #region Constructors

        public OrderService(IOrderRepository orderRepository)
        {
            OrderRepository = orderRepository;
        }

        #endregion Constructors

        #region Properties

        private IOrderRepository OrderRepository { get; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Adds Food Item Async
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> AddOrderAsync(Order model)
        {
            return await OrderRepository.InsertAsync(model);
        }

        /// <summary>
        /// Deletes food item async
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteOrderAsync(Guid orderId)
        {
            await OrderRepository.DeleteAsync(orderId);
            return await OrderRepository.DeleteAsync(orderId);
        }

        /// <summary>
        /// Edits food item async
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> EditOrderAsync(Order model)
        {
            return await OrderRepository.EditAsync(model);
        }

        /// <summary>
        /// Gets all food items async
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Order>> GetAllOrdersAsync()
        {
            return await OrderRepository.GetAllAsync();
        }

        public async Task<IList<Order>> GetAllOrdersWithFoodAsync()
        {
            return await OrderRepository.GetAllOrdersWithFoods();
        }

        /// <summary>
        /// Gets filtered food item async
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<Order> GetOrderAsync(GenericFilter filter)
        {
            return await OrderRepository.GetAsync(filter);
        }

        #endregion Methods
    }
}