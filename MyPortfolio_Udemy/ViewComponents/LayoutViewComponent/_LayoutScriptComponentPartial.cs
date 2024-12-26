using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Udemy.ViewComponents.LayoutViewComponent
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
