using Microsoft.AspNetCore.Mvc;
using Resty.Service.Common.Services;
using System.Threading.Tasks;

namespace Resty.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class AdminController : Controller
    {
        #region Constructors

        public AdminController(IOrderService orderService)
        {
            OrderService = orderService;
        }

        #endregion Constructors

        #region Properties

        private IOrderService OrderService { get; }

        #endregion Properties

        #region Methods

        public async Task<IActionResult> GetOrderPartial()
        {
            ViewBag.Orders = await OrderService.GetAllOrdersWithFoodAsync();

            return PartialView("Partials/_OrderPartial");
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Orders = await OrderService.GetAllOrdersWithFoodAsync();

            return View();
        }

        #endregion Methods
    }
}