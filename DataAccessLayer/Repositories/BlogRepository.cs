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
    public class BlogRepository : IBlogDal
    {
        Context context = new Context();
        public void addBlog(Blog blog)
        {
            context.Add(blog);
            context.SaveChanges();
        }

        public void delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void deleteCategory(Blog blog)
        {
            context.Remove(blog);
            context.SaveChanges();
        }

        public List<Blog> getAllBlog()
        {
            return context.Blogs.ToList();
        }

        public Blog getByBlogId(int id)
        {
            return context.Blogs.Find(id);
        }

        public Blog getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> getListAll()
        {
            throw new NotImplementedException();
        }

        public void insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public void update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void updateCategory(Blog blog)
        {
            context.Update(blog);
            context.SaveChanges();
        }
    }
}
