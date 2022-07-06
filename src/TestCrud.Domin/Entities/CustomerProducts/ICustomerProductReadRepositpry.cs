using Crud.Domin.BaseRepositories;
using Crud.Domin.Entities.Customers;

namespace Crud.Domin.Entities.CustomerProducts
{
    public interface ICustomerProductReadRepository : IBaseReadRepository<CustomerProduct>
    {
        CustomerProduct[] GetCustomerProductsByCustomerId(long CustomerId);
    }
}
