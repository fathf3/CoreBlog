using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
              _categoryDal = categoryDal;
        }
        public void addCategory(Category category)
        {
            _categoryDal.insert(category);
        }

        public void deleteCategory(Category category)
        {
            _categoryDal.delete(category);
        }

        public List<Category> getAllCategories()
        {
            return _categoryDal.getListAll();
        }

        public List<Category> getAllCategories(int id)
        {
            throw new NotImplementedException();
        }

        public Category getCategoryById(int id)
        {
            return _categoryDal.getById(id);
        }

        public void updateCategory(Category category)
        {
            _categoryDal.update(category);
        }
    }
}
