using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Resty.Service.Common.Services;

namespace Resty.Web.Controllers
{
    public class AdminController : Controller
    {
        public IFoodItemService FoodItemService { get; }

        public AdminController(IFoodItemService foodItemService)
        {
            FoodItemService = foodItemService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async  Task<IActionResult> FoodItemManagment()
        {
            var foodItems = await FoodItemService.GetAllFoodItemsAsync();
            return View(foodItems);
        }
    }
}