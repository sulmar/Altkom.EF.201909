using Altkom.Shop.IRepositories;
using Altkom.Shop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Altkom.Shop.DbRepositories
{
    public class DbEntityRepository<TEntity> : IEntityRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        protected readonly ShopContext context;

        protected DbSet<TEntity> entities => context.Set<TEntity>();

        public DbEntityRepository(ShopContext context)
        {
            this.context = context;
        }

        public virtual void Add(TEntity entity)
        {
            Console.WriteLine(context.Entry(entity).State);

            entities.Add(entity);

            Console.WriteLine(context.Entry(entity).State);

            context.SaveChanges();

            Console.WriteLine(context.Entry(entity).State);
        }

        public virtual ICollection<TEntity> Get()
        {
            return entities.AsNoTracking().ToList();
        }

        public virtual TEntity Get(int id)
        {
            return entities.Find(id);
        }

        public virtual void Remove(int id)
        {
            // TEntity entity = Get(id);

            TEntity entity = new TEntity() { Id = id };

            Console.WriteLine(context.Entry(entity).State);

            context.Entry(entity).State = EntityState.Deleted;

            // entities.Remove(entity);

            Console.WriteLine(context.Entry(entity).State);

            context.SaveChanges();
            Console.WriteLine(context.Entry(entity).State);

        }

        public virtual void Update(TEntity entity)
        {
            Console.WriteLine(context.Entry(entity).State);

            entities.Update(entity);

            // context.Entry(entity).Property(p=>p.Id).IsModified

            // context.Entry(entity).Property(p => p.Id).CurrentValue = 100;

            Console.WriteLine(context.Entry(entity).State);

            context.SaveChanges();

            Console.WriteLine(context.Entry(entity).State);
        }
    }
}
