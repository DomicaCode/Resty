using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Resty.Model.Models;
using Resty.Service.Common.Services;
using Resty.Web.Models.Food;

namespace Resty.Web.Controllers
{
    public class AdminController : Controller
    {
        public IFoodItemService FoodItemService { get; }
        public IMapper Mapper { get; }

        public AdminController(IFoodItemService foodItemService, IMapper mapper)
        {
            FoodItemService = foodItemService;
            Mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> FoodItemManagment()
        {
            var foodItems = await FoodItemService.GetAllFoodItemsAsync();

            ViewBag.FoodItems = Mapper.Map<IList<FoodItemViewModel>>(foodItems);

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> AddFoodItem(FoodItemViewModel model)
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException("Model wrong", "model");
            }

            var mappedModel = Mapper.Map<FoodItem>(model);

            await FoodItemService.AddFoodItemAsync(mappedModel);

            Response.StatusCode = (int)HttpStatusCode.OK;
            return Json(new { success = true });

        }
    }
}