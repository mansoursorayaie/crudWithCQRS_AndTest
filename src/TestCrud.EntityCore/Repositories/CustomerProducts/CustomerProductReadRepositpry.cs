using Crud.Data.DataBase;
using Crud.Domin.Entities.CustomerProducts;
using System;
using System.Linq;
using System.Text;

namespace Crud.EntityCore.Repositories.CustomerProducts
{
    public class CustomerProductReadRepository : ICustomerProductReadRepository
    {
        private readonly IDbCrud _dbCrud;

        public CustomerProductReadRepository(IDbCrud dbCrud)
        {
            _dbCrud = dbCrud;
        }

        public CustomerProduct[] FindAll()
        {
            return _dbCrud.DbContext.Set<CustomerProduct>().ToArray();
        }

        public CustomerProduct GetById(long id)
        {
            return _dbCrud.DbContext.Set<CustomerProduct>().Find(id);
        }

        public CustomerProduct[] GetCustomerProductsByCustomerId(long CustomerId)
        {
            return _dbCrud.DbContext.Set<CustomerProduct>().Where(x=>x.CustomerId==CustomerId).ToArray();
        }
    }
}
