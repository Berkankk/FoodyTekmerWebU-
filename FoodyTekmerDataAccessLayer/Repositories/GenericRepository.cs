using FoodyTekmerDataAccessLayer.Abstract;
using FoodyTekmerDataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerDataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class

    {
        FoodyContext contex = new FoodyContext();
        public void Add(T entity)
        {
            contex.Set<T>().Add(entity);
            contex.SaveChanges();
        }

        public void Delete(int id)
        {
            var value = contex.Set<T>().Find(id);
            contex.Set<T>().Remove(value);
            contex.SaveChanges();

        }

        public List<T> GetAllList()
        {
            return contex.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return contex.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            contex.Set<T>().Update(entity);
            contex.SaveChanges();
        }
    }
}
