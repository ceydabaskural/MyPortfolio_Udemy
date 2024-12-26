using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Udemy.DAL.Context;
using MyPortfolio_Udemy.DAL.Entities;

namespace MyPortfolio_Udemy.Controllers
{
    public class TestimonialController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var value = context.Testimonials.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteTestimonial(int id)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
