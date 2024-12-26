using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Udemy.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
