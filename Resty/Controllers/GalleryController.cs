using Microsoft.AspNetCore.Mvc;

namespace Resty.Web.Controllers
{
    public class GalleryController : Controller
    {
        #region Methods

        public IActionResult Index()
        {
            return View();
        }

        #endregion Methods
    }
}