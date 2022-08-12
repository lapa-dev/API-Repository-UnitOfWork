using Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IUnitOfWork
    {
        public IRepository<Product> Products { get; }
        public IRepository<Category> Categories { get; }
        public void Save();
    }
}
