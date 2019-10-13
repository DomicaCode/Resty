using Microsoft.AspNetCore.Mvc;

namespace Resty.Web.Areas.Global.Views.Shared.Components.Highlights
{
    public class HighlightsViewComponent : ViewComponent
    {
        #region Methods

        public IViewComponentResult Invoke()
        {
            return View();
        }

        #endregion Methods
    }
}