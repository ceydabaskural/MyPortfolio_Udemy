using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Udemy.DAL.Context;

namespace MyPortfolio_Udemy.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Testimonials.OrderByDescending(x =>x.TestimonialId).Take(4).ToList();
            return View(value);
        }
    }
}
