using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface IBlogService
    {
        void addBlog(Blog blog);
        void deleteBlog(Blog blog);
        void updateBlog(Blog blog);
        List<Blog> getAllBlogs();
        Blog getBlogById(int id);
        List<Blog> getAllBlogListWithCategory();

    }
}
