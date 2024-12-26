using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Udemy.DAL.Context;

namespace MyPortfolio_Udemy.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1=context.Features.OrderByDescending(x=>x.FeatureId).Select(x=>x.Title).FirstOrDefault();
            ViewBag.v2=context.Features.OrderByDescending(x=>x.FeatureId).Select(x=>x.Description).FirstOrDefault();
            return View();
        }
    }
}
