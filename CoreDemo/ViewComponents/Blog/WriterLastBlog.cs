using BusinessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        
        public IViewComponentResult Invoke()
        {
            var values = blogManager.getBlogListByWriter(3);
            return View(values);
        }
    }
}
