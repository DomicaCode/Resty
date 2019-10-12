using Microsoft.AspNetCore.Mvc;

namespace Resty.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class AdminController : Controller
    {
        #region Methods

        public IActionResult Index()
        {
            return View();
        }

        #endregion Methods
    }
}