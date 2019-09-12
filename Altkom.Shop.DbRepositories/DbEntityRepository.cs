using Altkom.Shop.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Altkom.Shop.DbRepositories
{
    public class DbEntityRepository<TEntity> : IEntityRepository<TEntity>
        where TEntity : class
    {
        protected readonly ShopContext context;

        protected DbSet<TEntity> entities => context.Set<TEntity>();

        public DbEntityRepository(ShopContext context)
        {
            this.context = context;
        }

        public virtual void Add(TEntity entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }

        public virtual ICollection<TEntity> Get()
        {
            return entities.ToList();
        }

        public virtual TEntity Get(int id)
        {
            return entities.Find(id);
        }

        public virtual void Remove(int id)
        {
            entities.Remove(Get(id));
            context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            entities.Update(entity);
            context.SaveChanges();
        }
    }
}
