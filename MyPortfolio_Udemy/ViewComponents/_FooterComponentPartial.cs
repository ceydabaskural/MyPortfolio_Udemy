using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Udemy.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
