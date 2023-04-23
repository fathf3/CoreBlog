using BusinessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager CategoryManager = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = CategoryManager.getAllCategories();
            return View(values);
        }

    }
}
