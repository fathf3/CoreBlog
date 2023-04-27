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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public About getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> getList()
        {
            return _aboutDal.getListAll();
        }

        public void Tadd(About t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(About t)
        {
            throw new NotImplementedException();
        }

        public void Tupdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}
