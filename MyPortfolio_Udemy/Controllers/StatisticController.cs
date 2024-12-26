using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Udemy.DAL.Context;

namespace MyPortfolio_Udemy.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v5 = context.Testimonials.Count();
            ViewBag.v6 = context.SocialMedias.Count();
            ViewBag.v7 = context.ToDoLists.Where(x=>x.Status==true).Count();
            ViewBag.v8 = context.ToDoLists.Where(x=>x.Status==false).Count();
            ViewBag.v9 = context.Skills.OrderByDescending(x=>x.SkillId).Select(x=>x.Value).FirstOrDefault();
            ViewBag.v10 = context.Portfolios.Count();
            ViewBag.v11 = context.Messages.OrderByDescending(x => x.MessageId).Select(x=>x.Email).FirstOrDefault();
            ViewBag.v12 = context.Portfolios.OrderByDescending(x => x.PortfolioId).Select(x => x.Title).FirstOrDefault();

            return View();
        }
    }
}
