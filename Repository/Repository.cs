using Microsoft.EntityFrameworkCore;
using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DevTestContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(DevTestContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity data) => _dbSet.Add(data);

        public IEnumerable<TEntity> Get() => _dbSet.ToList();

        public TEntity Get(int id) => _dbSet.Find(id);

        public void Remove(int id)
        {
            var toRemove = _dbSet.Find(id);
            _dbSet.Remove(toRemove);
        }

        public void Update(TEntity data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }

        public void Save() => _context.SaveChanges();

      
    }
}
