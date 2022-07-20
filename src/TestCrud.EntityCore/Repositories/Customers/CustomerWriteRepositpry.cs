using Crud.Data.DataBase;
using Crud.Domin.Entities.Customers;
using System.Collections.Generic;

namespace Crud.EntityCore.Repositories.Customers
{
    public class CustomerWriteRepository : ICustomerWriteRepository
    {
        private readonly IDbCrud _dbCrud;

        public CustomerWriteRepository(
            IDbCrud dbCrud)
        {
            _dbCrud = dbCrud;
        }

        public bool Delete(long id)
        {
            var entity = _dbCrud.DbContext.Set<Customer>().Find(id);

            if (entity == null)
            {
                return false;
            }

            _dbCrud.DbContext.Set<Customer>().Remove(entity);
            SaveChanges();

            return true;
        }

        public Customer Insert(Customer customer)
        {
            _dbCrud.DbContext.Set<Customer>().Add(customer);

            SaveChanges();

            return customer;
        }

        public Customer Update(Customer customer)
        {
            var entity = _dbCrud.DbContext.Set<Customer>().Find(customer.Id);

            if (entity == null)
            {
                return null;
            }

            entity.Firstname = customer.Firstname;
            entity.Lastname = customer.Lastname;
            entity.DateOfBirth = customer.DateOfBirth;
            entity.PhoneNumber = customer.PhoneNumber;
            entity.Email = customer.Email;
            SaveChanges();

            return customer;
        }

        private void SaveChanges()
        {
            _dbCrud.DbContext.SaveChanges();
        }
    }
}
