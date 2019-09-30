using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
   public class GenericRepository<T> :IGenericRepository<T> where T:class
     {
       internal BusBookingSystemEntities context;
       internal DbSet<T> dbSet;
       public GenericRepository(BusBookingSystemEntities context)
       {
           this.context = context;
           this.dbSet = context.Set<T>();
       }
       public IEnumerable<T> GetAll()
       {
           return dbSet.ToList();
       }
       public IEnumerable<T> GetAllByProperty(String property)
       {
           return dbSet.Include(property).ToList();
       }
       public T GetById(long ModelId)
       {
           return dbSet.Find(ModelId);
       }

       public T GetByProperty(String property)
       {
           return dbSet.Include(property).First();
       }

       public T Add(T model)
       {
           T newModel = dbSet.Add(model);
           return newModel;
       }

       public T Delete(long ModelId)
       {
           T modelToDelete = GetById(ModelId);
           dbSet.Remove(modelToDelete);
           return modelToDelete;
       }

       public T Update(T model)
       {
           dbSet.Attach(model);
           context.Entry(model).State = EntityState.Modified;
           return model;
       }

       public void Dispose()
       {
           if (context != null)
               context.Dispose();
       }
    }
}
