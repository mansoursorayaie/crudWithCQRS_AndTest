using Crud.Domin.Configurations.CustomerProducts;
using Crud.Domin.Configurations.Customers;
using Crud.Domin.Configurations.Products;
using Crud.Domin.Entities.CustomerProducts;
using Crud.Domin.Entities.Customers;
using Crud.Domin.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Crud.Data.DataBase
{
    public class DbCrud : DbContext, IDbCrud
    {
        public DbCrud(DbContextOptions<DbCrud> options) : base(options)
        {
        }

        public DbCrud DbContext => this;

        public void EnsureCreated()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new CustomerProductConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
