using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Resty.Service.Common.Services;

namespace Resty.Web.Controllers
{
    public class MenuController : Controller
    {
        public MenuController(IFoodItemService foodItemService)
        {
            FoodItemService = foodItemService;
        }

        public IFoodItemService FoodItemService { get; }

        public async Task<IActionResult> Index()
        {
            ViewBag.Food = await FoodItemService.GetAllFoodItemsAsync();
            return View();
        }
    }
}