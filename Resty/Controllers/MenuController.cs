using Microsoft.AspNetCore.Mvc;
using Resty.Service.Common.Services;
using System.Threading.Tasks;

namespace Resty.Web.Controllers
{
    public class MenuController : Controller
    {
        #region Constructors

        public MenuController(IFoodItemService foodItemService)
        {
            FoodItemService = foodItemService;
        }

        #endregion Constructors

        #region Properties

        private IFoodItemService FoodItemService { get; }

        #endregion Properties

        #region Methods

        public async Task<IActionResult> Index()
        {
            var foodItems = await FoodItemService.GetAllFoodItemsAsync();
            return View(foodItems);
        }

        #endregion Methods
    }
}