using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Udemy.DAL.Context;

namespace MyPortfolio_Udemy.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext context= new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle=context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail=context.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }

        //[HttpGet]
        //public IActionResult DownloadCV()
        //{
        //    // CV dosyasının yolu
        //    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "cv.pdf");
        //    var fileName = "cv.pdf";

        //    // Dosyayı indir
        //    var fileBytes = System.IO.File.ReadAllBytes(filePath);
        //    return File(fileBytes, "application/pdf", fileName);
        //}
    }
}
