using Crud.Data.DataBase;
using Crud.Domin.Entities.Products;
using Crud.Domin.Enums;
using System;
using System.Linq;
using System.Text;

namespace Crud.EntityCore.Repositories.Products
{
    public class ProductReadRepository : IProductReadRepository
    {
        private readonly IDbCrud _dbCrud;

        public ProductReadRepository(IDbCrud dbCrud)
        {
            _dbCrud = dbCrud;
        }

        public Product[] FindAll()
        {
            return _dbCrud.DbContext.Set<Product>().ToArray();
        }

        public Product GetById(long id)
        {
            return _dbCrud.DbContext.Set<Product>().Find(id);
        }

        public Product[] GetProductsByProductType(ProductType productType)
        {
            return _dbCrud.DbContext.Set<Product>().Where(x=>x.ProductType== productType).ToArray();
        }
    }
}
