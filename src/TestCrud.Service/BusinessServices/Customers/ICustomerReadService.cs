using Crud.Service.Dtos.Customers;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.BusinessServices.Customers
{
    public interface ICustomerReadService
    {
        BaseServiceResult<CustomerModel[]> FindAll();
        BaseServiceResult<CustomerModel> GetById(long id);
    }
}
