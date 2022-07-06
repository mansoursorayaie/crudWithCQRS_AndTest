using Crud.Data.DataBase;
using Crud.Domin.Entities.Customers;
using System;
using System.Linq;
using System.Text;

namespace Crud.EntityCore.Repositories.Customers
{
    public class CustomerReadRepository : ICustomerReadRepository
    {
        private readonly IDbCrud _dbCrud;

        public CustomerReadRepository(IDbCrud dbCrud)
        {
            _dbCrud = dbCrud;
        }

        public Customer[] FindAll()
        {
            return _dbCrud.DbContext.Set<Customer>().ToArray();
        }

        public Customer GetById(long id)
        {
            return _dbCrud.DbContext.Set<Customer>().Find(id);
        }
    }
}
