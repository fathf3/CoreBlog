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
    public class NotificationManager : INatificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public Notification getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> getList()
        {
            return _notificationDal.getListAll();
        }

        public void Tadd(Notification t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Notification t)
        {
            throw new NotImplementedException();
        }

        public void Tupdate(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
