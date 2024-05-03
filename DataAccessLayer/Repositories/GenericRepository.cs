using DataAccessLayer.Abstract;
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
        public void Delete(T e)
        {
            using var c = new Context(); 
            c.Remove(e);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id); 
        }

        public List<T> GetListAll()
        {   using var c = new Context();     
            return c.Set<T>().ToList(); 
        }

        public void Insert(T e)
        {
            using var c = new Context();
            c.Add(e);
            c.SaveChanges(); 
        }

        public void Update(T e)
        {
            using var c = new Context();
            c.Update(e); 
            c.SaveChanges(); 
        }
    }
}
