using Microsoft.AspNetCore.Mvc;

namespace Resty.Web.Areas.Global.Controllers
{
    [Area("Global")]
    public class HomeController : Controller
    {
        #region Methods

        public IActionResult Index()
        {
            return View();
        }

        #endregion Methods
    }
}