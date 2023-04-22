﻿using DataAccessLayer.Abstracts;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void delete(T t)
        {
            using var context = new Context();
            context.Remove(t);
            context.SaveChanges();
        }

        public T getById(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
        }

        public List<T> getListAll()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public void insert(T t)
        {
            using var context = new Context();
            context.Add(t);
            context.SaveChanges();
        }

        public void update(T t)
        {
            using var context = new Context();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
