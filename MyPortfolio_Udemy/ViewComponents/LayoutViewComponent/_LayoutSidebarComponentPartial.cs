using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Udemy.ViewComponents.LayoutViewComponent
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
