using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Udemy.DAL.Context;

namespace MyPortfolio_Udemy.Controllers
{
    public class DashboardController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var value = context.Portfolios.ToList();
            ViewBag.projects = context.Portfolios.Select(a=>a.Title).Count();
            ViewBag.testimonials = context.Testimonials.Select(a=>a.NameSurname).Count();
            ViewBag.skills = context.Skills.Select(a=>a.Title).Count();
            ViewBag.toDo = context.ToDoLists.Select(a=>a.Title).Count(); //count halde
            //---
            ViewBag.toDoList = context.ToDoLists.Select(a => a.Title).FirstOrDefault();//list halde
            ViewBag.toDoId = context.ToDoLists.Select(a => a.ToDoListId).FirstOrDefault();//tablolarda gerekti
            ViewBag.messages = context.Messages.Select(x=>x.MessageId).Count();
            ViewBag.experiences = context.Experiences.Select(x=>x.Head).Count();
            ViewBag.completedTasks = context.ToDoLists.Select(x=>x.Status==true).Count();
            ViewBag.socialMedias=context.SocialMedias.Select(x=>x.Title).Count();
            return View(value);
        }
    }
}
