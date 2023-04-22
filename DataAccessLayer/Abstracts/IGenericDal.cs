using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
    public interface IGenericDal<T> where T : class
    {
        List<T> getListAll();
        void insert(T t);
        void update(T t);
        void delete(T t);
        T getById(int id);
    }
}
