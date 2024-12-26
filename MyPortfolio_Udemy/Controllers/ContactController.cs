using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Udemy.DAL.Context;
using MyPortfolio_Udemy.DAL.Entities;

namespace MyPortfolio_Udemy.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteContact(int id)
        {
            var contact = context.Contacts.Find(id);
            context.Remove(contact);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    message.IsRead = false;
                    message.SendDate = DateTime.Now;
                    context.Messages.Add(message); // Ekleme işlemini yap
                    context.SaveChanges(); // Veritabanına değişiklikleri kaydet
                    ViewBag.flag = true;
                    TempData["SuccessMessage"] = "Mesajınız gönderildi. Teşekkürler!";
                    return RedirectToAction("Index", "Default"); // Tekrar yönlendirme yap
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                TempData["ErrorMessage"] = "Bir şeyler yanlış gitti. Lütfen yeniden deneyin!";
            }
            return View();
        }
    }
}
