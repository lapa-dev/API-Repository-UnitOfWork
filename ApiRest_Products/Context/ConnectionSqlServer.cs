using Microsoft.EntityFrameworkCore;
using Models;
using Models.Data;
using System;

namespace ApiRest_Products.Context
{
    [Obsolete]
    public class ConnectionSqlServer:DbContext
    {
        public ConnectionSqlServer(DbContextOptions<ConnectionSqlServer> options):base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
    }
}
