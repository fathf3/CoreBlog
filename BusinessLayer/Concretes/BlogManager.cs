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

        public List<Blog> getAllBlogListWithCategory()
        {
            return _blogDal.getListWithCategory();
        }

        public List<Blog> getListBlogWithCategoryName(int id)
        {
            return _blogDal.getListWithCategoryByWriter(id);
        }

        public List<Blog> getLast3Blog()
        {
            // sadece 3 post getirecek
            return _blogDal.getListAll().Take(3).ToList();
        }

        public List<Blog> getBlogListByWriter(int id)
        {
            return _blogDal.getListAll(x => x.writerId == id);
        }

        public List<Blog> getListByBlogId(int id)
        {
            return _blogDal.getListAll(x => x.blogId == id);
        }

        public void Tadd(Blog t)
        {
            _blogDal.insert(t);
        }

        public void Tdelete(Blog t)
        {
            _blogDal.delete(t);
        }

        public void Tupdate(Blog t)
        {
            _blogDal.update(t);
        }

        public List<Blog> getList()
        {
            throw new NotImplementedException();
        }

        public Blog getById(int id)
        {
            return _blogDal.getById(id);
        }
    }
}
