using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Udemy.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
