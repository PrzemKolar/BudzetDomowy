using BudzetDomowy.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        protected readonly HouseholdBudgetStorageContext context;
        private DbSet<T> entities;

        public Repository(HouseholdBudgetStorageContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetById(int id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            T entity = entities.SingleOrDefault(x => x.Id == id);
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
