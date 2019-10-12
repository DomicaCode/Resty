using Microsoft.AspNetCore.Mvc;

namespace Resty.Web.Views.Shared.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        #region Methods

        public IViewComponentResult Invoke()
        {
            return View();
        }

        #endregion Methods
    }
}