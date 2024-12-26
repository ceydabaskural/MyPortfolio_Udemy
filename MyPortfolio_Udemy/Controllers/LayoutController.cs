using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Udemy.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
