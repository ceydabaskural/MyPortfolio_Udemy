using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Udemy.Views.Shared.Components._LayoutHeadComponentPartial
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
