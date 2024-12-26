using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Udemy.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
