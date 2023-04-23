using BusinessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogManager.getAllBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id) {
            
            ViewBag.Id = id;
            var values = blogManager.getListByBlogId(id);
            return View(values);
        }


    }
}
