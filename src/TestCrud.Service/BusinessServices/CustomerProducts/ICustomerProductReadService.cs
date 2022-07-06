using Crud.Service.Dtos.CustomerProducts;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.BusinessServices.CustomerProducts
{
    public interface ICustomerProductReadService
    {
        BaseServiceResult<CustomerProductModel[]> FindAll();
        BaseServiceResult<CustomerProductModel> GetById(long id);
        BaseServiceResult<CustomerProductModel[]> GetCustomerProductsByCustomerId(long customerId);
    }
}
