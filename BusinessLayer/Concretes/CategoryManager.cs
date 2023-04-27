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

        public Category getById(int id)
        {
            return _categoryDal.getById(id);
        }

        public List<Category> getList()
        {
            return _categoryDal.getListAll();
        }

        public void Tadd(Category t)
        {
            _categoryDal.insert(t);
        }

        public void Tdelete(Category t)
        {
            _categoryDal.delete(t);
        }

        public void Tupdate(Category t)
        {
            _categoryDal.update(t);
        }


    }
}
