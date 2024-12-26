using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Udemy.ViewComponents.LayoutViewComponent
{
    public class _LayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
