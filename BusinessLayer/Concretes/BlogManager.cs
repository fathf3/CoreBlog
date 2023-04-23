using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void addBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void deleteBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> getAllBlogListWithCategory()
        {
            return _blogDal.getListWithCategort();
        }

        public List<Blog> getAllBlogs()
        {
            return _blogDal.getListAll();
        }

        public Blog getBlogById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> getListByBlogId(int id)
        {
            return _blogDal.getListAll(x => x.blogId == id);
        }

        public void updateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
