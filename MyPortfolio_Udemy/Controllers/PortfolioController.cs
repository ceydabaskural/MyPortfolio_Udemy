using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Udemy.DAL.Context;
using MyPortfolio_Udemy.DAL.Entities;

namespace MyPortfolio_Udemy.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult DownloadCV()
        {
            var filePath = "C:\\Users\\YourUserName\\Documents\\CV.pdf";  // Dosyanın tam yolu
            return File(filePath, "application/pdf", "CV.pdf");
        }

        public IActionResult Index()
        {
            var value= context.Portfolios.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            var value = context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value= context.Portfolios.Find(id);
            return View(value);
        }


        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
