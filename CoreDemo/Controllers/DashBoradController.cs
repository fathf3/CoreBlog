using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class DashBoradController : Controller
    {
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.blogCount = context.Blogs.Count().ToString();
            ViewBag.writerBlogCount = context.Blogs.Where(x=> x.writerId == 4).Count().ToString();
            ViewBag.categoryCount = context.Categories.Count().ToString();
            return View();
        }
    }
}
