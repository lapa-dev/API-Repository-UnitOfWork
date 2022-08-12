using Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DevTestContext _context;
        private IRepository<Product> _products;
        private IRepository<Category> _category;

        public UnitOfWork(DevTestContext context)
        {
            _context = context;
        }

        public IRepository<Product> Products
        {
            get {
                return _products == null
                    ? _products = new Repository<Product>(_context)
                    : _products;
            }
        }
        public IRepository<Category> Categories
        {
            get
            {
                return _category == null
                    ? _category = new Repository<Category>(_context)
                    : _category;
            }
        }

        public void Save() => _context.SaveChanges();
    }
}
