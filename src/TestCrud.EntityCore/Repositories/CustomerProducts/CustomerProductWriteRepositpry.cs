using Crud.Data.DataBase;
using Crud.Domin.Entities.CustomerProducts;
using System.Collections.Generic;

namespace Crud.EntityCore.Repositories.CustomerProducts
{
    public class CustomerProductWriteRepository : ICustomerProductWriteRepository
    {
        private readonly IDbCrud _dbCrud;

        public CustomerProductWriteRepository(
            IDbCrud dbCrud)
        {
            _dbCrud = dbCrud;
        }

        public bool Delete(long id)
        {
            var entity = _dbCrud.DbContext.Set<CustomerProduct>().Find(id);

            if (entity == null)
            {
                return false;
            }

            _dbCrud.DbContext.Set<CustomerProduct>().Remove(entity);
            SaveChanges();

            return true;
        }

        public CustomerProduct Insert(CustomerProduct customerProduct)
        {
            _dbCrud.DbContext.Set<CustomerProduct>().Add(customerProduct);

            SaveChanges();

            return customerProduct;
        }

        public CustomerProduct Update(CustomerProduct customerProduct)
        {
            var entity = _dbCrud.DbContext.Set<CustomerProduct>().Find(customerProduct.Id);

            if (entity == null)
            {
                return null;
            }

            entity.RegisterationNumber = customerProduct.RegisterationNumber;

            SaveChanges();

            return customerProduct;
        }

        private void SaveChanges()
        {
            _dbCrud.DbContext.SaveChanges();
        }
    }
}
