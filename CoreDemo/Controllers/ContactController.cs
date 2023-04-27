using BusinessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.contactDate = DateTime.Now;
            contact.contactStatus = true;
            contactManager.addContact(contact);
            return RedirectToAction("Index", "Blog");
        }

    }
}
