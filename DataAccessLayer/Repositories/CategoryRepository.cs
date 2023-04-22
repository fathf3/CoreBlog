using DataAccessLayer.Abstracts;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context context = new Context();
        public void addCategory(Category category)
        {
            context.Add(category);
            context.SaveChanges();
        }

        public void delete(Category t)
        {
            throw new NotImplementedException();
        }

        public void deleteCategory(Category category)
        {
            context.Remove(category);
            context.SaveChanges();
        }

        public List<Category> getAllCategory()
        {
            return context.Categories.ToList();
        }

        public Category getByCategoryId(int id)
        {
            return context.Categories.Find(id);
        }

        public Category getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> getListAll()
        {
            throw new NotImplementedException();
        }

        public void insert(Category t)
        {
            throw new NotImplementedException();
        }

        public void update(Category t)
        {
            throw new NotImplementedException();
        }

        public void updateCategory(Category category)
        {
            context.Update(category);
            context.SaveChanges();
        }
    }
}
