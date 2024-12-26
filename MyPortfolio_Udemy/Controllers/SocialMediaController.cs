using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Udemy.DAL.Context;
using MyPortfolio_Udemy.DAL.Entities;

namespace MyPortfolio_Udemy.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var value = context.SocialMedias.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(SocialMedia media)
        {
            var value = context.SocialMedias.Add(media);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult UpdateAccount(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAccount(SocialMedia media)
        {
            context.SocialMedias.Update(media);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteAccount(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
