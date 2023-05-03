using BusinessLayer.Concretes;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace CoreDemo.Controllers
{
    // -> Buraya yazılması durumunda butun ActionResult'lar Authorize olmak zorunda
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }

        public PartialViewResult WriterNavBar()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooter()
        {
            return  PartialView();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var writerValues = writerManager.getById(4);
            return View(writerValues);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidator rules = new WriterValidator();
            ValidationResult result = rules.Validate(writer);
            if(result.IsValid)
            {
                writerManager.Tupdate(writer);
                return RedirectToAction("Index", "DashBorad");
            }
            else
            {
                foreach(var item in result.Errors) {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View(result);


        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer writer = new Writer();
            if(p.writerImage != null)
            {
                var extension = Path.GetExtension(p.writerImage.FileName);
                var newImageName =Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), 
                    "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.writerImage.CopyTo(stream);
                writer.writerImage = newImageName;
            }
            writer.writerStatus = true;
            writer.writerName = p.writerName;
            writer.writerAbout = p.writerAbout;
            writer.writerPassword = p.writerPassword;
            writer.writerMail = p.writerMail;
            writerManager.Tadd(writer);
            return RedirectToAction("Index", "DashBorad");
        }

    }
}
