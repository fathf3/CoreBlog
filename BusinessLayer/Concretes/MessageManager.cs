using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> getList()
        {
            throw new NotImplementedException();
        }

        public List<Message> getListByWriter(string p)
        {
            return _messageDal.getListAll(x => x.receiver == p);
        }

        public void Tadd(Message t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Message t)
        {
            throw new NotImplementedException();
        }

        public void Tupdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
