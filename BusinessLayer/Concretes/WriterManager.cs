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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer getById(int id)
        {
            return _writerDal.getById(id);
        }

        public List<Writer> getList()
        {
            return _writerDal.getListAll();
        }

        public List<Writer> getWriterById(int id)
        {
            return _writerDal.getListAll(x => x.WriterId == id);
        }

        public void Tadd(Writer t)
        {
            _writerDal.insert(t);
        }

        public void Tdelete(Writer t)
        {
            _writerDal.delete(t);
        }

        public void Tupdate(Writer t)
        {
            _writerDal.update(t);
        }
    }
}
