using Crud.Service.Dtos.Customers;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.BusinessServices.Customers
{
    public interface ICustomerWriteService
    {
        BaseServiceResult<CustomerModel> Insert(CustomerModel customer);
        BaseServiceResult<CustomerModel> Update(CustomerModel customer);
        BaseServiceResult<bool> Delete(long id);
    }
}
