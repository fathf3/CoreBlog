using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [Authorize] // -> Buraya yazılması durumunda butun ActionResult'lar Authorize olmak zorunda
    public class WriterController : Controller
    {
        
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

    }
}
