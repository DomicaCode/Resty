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

namespace Resty.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class FoodItemCategoryController : Controller
    {
        #region Constructors

        public FoodItemCategoryController(IFoodItemCategoryService foodItemCategoryService, IMapper mapper)
        {
            FoodItemCategoryService = foodItemCategoryService;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        private IFoodItemCategoryService FoodItemCategoryService { get; set; }
        private IMapper Mapper { get; set; }

        #endregion Properties

        #region Methods

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> AddFoodItemCategory(FoodItemCategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException("Model wrong", nameof(model));
            }

            var mappedModel = Mapper.Map<FoodItemCategory>(model);

            if (await FoodItemCategoryService.AddFoodItemCategoryAsync(mappedModel))
            {
                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteFoodItemCategory(Guid foodId)
        {
            if (foodId == null)
            {
                throw new ArgumentException("Id wrong", nameof(foodId));
            }

            if (await FoodItemCategoryService.DeleteFoodItemCategoryAsync(foodId))
            {
            }

            return Json(true);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> EditFoodItemCategory(FoodItemCategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException("Model wrong", nameof(model));
            }

            var mappedModel = Mapper.Map<FoodItemCategory>(model);

            if (await FoodItemCategoryService.EditFoodItemCategoryAsync(mappedModel))
            {
                Response.StatusCode = (int)HttpStatusCode.OK;
                return RedirectToAction("Index");
            }
            return Json(new { success = false });
        }

        public async Task<IActionResult> Index()
        {
            var foodItemCategories = await FoodItemCategoryService.GetAllFoodItemCategoriesAsync();

            ViewBag.FoodItemCategories = Mapper.Map<IList<FoodItemCategoryViewModel>>(foodItemCategories);

            return View();
        }

        #endregion Methods
    }
}