using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Resty.Model.Models;
using Resty.Service.Common.Services;
using Resty.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resty.Web.Areas.Global.Controllers
{
    [Area("Global")]
    public class MenuController : Controller
    {
        #region Constructors

        public MenuController(IFoodItemService foodItemService, IOrderService orderService, IMapper mapper)
        {
            FoodItemService = foodItemService;
            OrderService = orderService;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        public IMapper Mapper { get; }
        private IFoodItemService FoodItemService { get; }
        private IOrderService OrderService { get; }

        #endregion Properties

        #region Methods

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> AddOrder(OrderViewModel model)
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException("Model invalid", nameof(model));
            }

            var mappedModel = Mapper.Map<Order>(model);

            await OrderService.AddOrderAsync(mappedModel).ConfigureAwait(false);

            return new JsonResult(new { success = "true" });
        }

        public async Task<IActionResult> Index()
        {
            var foodItems = await FoodItemService.GetAllFoodItemsAsync("FoodItemCategory").ConfigureAwait(false);

            var groupedItems = foodItems.GroupBy(fi => fi.FoodItemCategory).ToArray();

            return View(new MenuIndexViewModel
            {
                FoodItems = groupedItems
            });
        }


        public class MenuIndexViewModel
        {
            public IGrouping<FoodItemCategory, FoodItem>[] FoodItems { get; set; }
        }

        #endregion Methods
    }
}