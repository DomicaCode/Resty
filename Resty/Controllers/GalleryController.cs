using Microsoft.AspNetCore.Mvc;

namespace Resty.Web.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}