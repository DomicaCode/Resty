using Microsoft.AspNetCore.Mvc;

namespace Resty.Web.Areas.Administration.Views.Shared.Components.AdminHeader
{
    public class AdminHeaderViewComponent : ViewComponent
    {
        #region Methods

        public IViewComponentResult Invoke()
        {
            return View();
        }

        #endregion Methods
    }
}