using Crud.Data.DataBase;
using Crud.Domin.Entities.Products;
using Crud.Domin.Enums;
using System.Collections.Generic;

namespace Crud.EntityCore.Repositories.Products
{
    public class ProductWriteRepository : IProductWriteRepository
    {
        private readonly IDbCrud _dbCrud;

        public ProductWriteRepository(
            IDbCrud dbCrud)
        {
            _dbCrud = dbCrud;
        }

        public bool Delete(long id)
        {
            var entity = _dbCrud.DbContext.Set<Product>().Find(id);

            if (entity == null)
            {
                return false;
            }

            _dbCrud.DbContext.Set<Product>().Remove(entity);
            SaveChanges();

            return true;
        }

        public Product Insert(Product product)
        {
            _dbCrud.DbContext.Set<Product>().Add(product);

            SaveChanges();

            return product;
        }

        public Product Update(Product product)
        {
            var entity = _dbCrud.DbContext.Set<Product>().Find(product.Id);

            if (entity == null)
            {
                return null;
            }

            entity.Name = product.Name;
            entity.ProductType = product.ProductType;

            SaveChanges();

            return product;
        }

        private void SaveChanges()
        {
            _dbCrud.DbContext.SaveChanges();
        }
    }
}
