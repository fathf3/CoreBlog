using DataAccessLayer.Abstracts;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> getListWithCategort()
        {
            using(var c= new Context())
            {
                // Include Blog -> Category e ulasmamizi saglar
                return c.Blogs.Include(x => x.category).ToList();
            }
        }
    }
}
