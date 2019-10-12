using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Resty.Model.Models;
using Resty.Service.Common.Services;
using Resty.Web.Models.Food;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Resty.Web.Controllers
{
    public class AdminController : Controller
    {
        #region Constructors

        public AdminController(IFoodItemService foodItemService, IMapper mapper)
        {
            FoodItemService = foodItemService;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        private IFoodItemService FoodItemService { get; }
        private IMapper Mapper { get; }

        #endregion Properties

        #region Methods

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> AddFoodItem(FoodItemViewModel model)
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException("Model wrong", nameof(model));
            }

            var mappedModel = Mapper.Map<FoodItem>(model);

            if (await FoodItemService.AddFoodItemAsync(mappedModel))
            {
                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteFoodItem(Guid foodId)
        {
            if (foodId == null)
            {
                throw new ArgumentException("Id wrong", nameof(foodId));
            }

            if (await FoodItemService.DeleteFoodItemAsync(foodId))
            {
            }

            return Json(true);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> EditFoodItem(FoodItemViewModel model)
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException("Model wrong", nameof(model));
            }

            var mappedModel = Mapper.Map<FoodItem>(model);

            if (await FoodItemService.EditFoodItemAsync(mappedModel))
            {
                Response.StatusCode = (int)HttpStatusCode.OK;
                return RedirectToAction("FoodItemManagement");
            }
            return Json(new { success = false });
        }

        public async Task<IActionResult> FoodItemManagement()
        {
            var foodItems = await FoodItemService.GetAllFoodItemsAsync();

            ViewBag.FoodItems = Mapper.Map<IList<FoodItemViewModel>>(foodItems);

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        #endregion Methods
    }
}