using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositorys
{
    public class GenericBaseRepository<CContext,TEntity> where TEntity:class where CContext:DbEmlakEntities1 ,new()
    {
        public CContext Context { get; set; } = new CContext();

        public List<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public TEntity Add(TEntity entity)
        {
            var result=Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
            return result;
        }

        public void Delete(int id)
        {
            var entity = Context.Set<TEntity>().Find(id);
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();        
        }

        public TEntity Find(int id)
        {
            var result = Context.Set<TEntity>().Find(id);
            return result;
        }

        
    }
}
