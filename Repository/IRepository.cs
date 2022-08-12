using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        void Add(TEntity data);
        void Remove(int id);
        void Update(TEntity data);
        void Save();

    }
}
