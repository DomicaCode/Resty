using Microsoft.AspNetCore.Mvc;

namespace Resty.Web.Controllers
{
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