using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Udemy.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
