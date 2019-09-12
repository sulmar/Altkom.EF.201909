﻿using System.Collections.Generic;

namespace Altkom.Shop.IRepositories
{
    public interface IEntityRepository<TEntity>
    {
        ICollection<TEntity> Get();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(int id);
    }
}
