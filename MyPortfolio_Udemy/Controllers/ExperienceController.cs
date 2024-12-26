using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Udemy.DAL.Context;
using MyPortfolio_Udemy.DAL.Entities;

namespace MyPortfolio_Udemy.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var value = context.Experiences.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value= context.Experiences.Find(id);
            return View(value);
        }


        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
