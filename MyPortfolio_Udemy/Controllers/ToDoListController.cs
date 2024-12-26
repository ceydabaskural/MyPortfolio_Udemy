using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Udemy.DAL.Context;
using MyPortfolio_Udemy.DAL.Entities;
using NuGet.Protocol.Plugins;

namespace MyPortfolio_Udemy.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDoList(ToDoList list)
        {
            list.Status = false; //oluştururken başlangıçta false gelsin
            var value = context.ToDoLists.Add(list);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList list)
        {
            var value = context.ToDoLists.Update(list);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeIsStatusToTrue(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status=true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeIsStatusToFalse(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
