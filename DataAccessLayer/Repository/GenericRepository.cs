using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Contex();

            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetList()
        {
            using var c = new Contex();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Contex();

            c.Add(t);
        }

        public void Update(T t)
        {
            using var c = new Contex();

            c.Update(t);
        }
    }
}

