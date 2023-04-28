using BusinessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using EntityLayer.Concrete;
using FluentValidation;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
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
        
        public IActionResult DeleteBlog(int id)
        {
            var values = blogManager.getById(3);
            blogManager.Tdelete(values);
            return RedirectToAction("BlogListByWriter");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValue = blogManager.getById(id);
            List<SelectListItem> categoryValues = (from x in categoryManager.getList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.categoryName,
                                                       Value = x.categoryId.ToString()
                                                   }).ToList();
            ViewBag.categoryList = categoryValues;

            return View(blogValue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            
            blogManager.Tupdate(blog);
            
            return RedirectToAction("BlogListByWriter");
        }

        public IActionResult BlogListByWriter()
        {

            var values = blogManager.getListBlogWithCategoryName(4);
            return View(values);
                

        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            
            List<SelectListItem> categoryValues = (from x in categoryManager.getList()
                                                   select new SelectListItem
                                                   {
                                                       Text=x.categoryName,
                                                       Value=x.categoryId.ToString()
                                                   }).ToList();
            ViewBag.categoryList = categoryValues;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {

            BlogValidator  rules = new BlogValidator();
            ValidationResult result = rules.Validate(blog);
            if (result.IsValid)
            {
                blog.blogStatus = true;
                blog.blogCreateDate=DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.writerId = 4;
                blogManager.Tadd(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }


    }
}
