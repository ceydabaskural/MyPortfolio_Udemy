using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Udemy.DAL.Context;

namespace MyPortfolio_Udemy.ViewComponents
{
    public class _PortfolioComponentPartial: ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Portfolios.ToList();
            return View(value);
        }
    }
}
