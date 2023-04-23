using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface ICategoryService
    {
        void addCategory(Category category);
        void deleteCategory(Category category);
        void updateCategory(Category category);
        List<Category> getAllCategories(int id);
        Category getCategoryById(int id);

    }
}
