using Microsoft.AspNetCore.Mvc;

namespace Resty.Web.Views.Shared.Components.AdminSideMenu
{
    public class AdminSideMenuViewComponent : ViewComponent
    {
        #region Methods

        public IViewComponentResult Invoke()
        {
            return View();
        }

        #endregion Methods
    }
}