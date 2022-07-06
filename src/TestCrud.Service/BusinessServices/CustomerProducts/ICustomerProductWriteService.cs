using Crud.Service.Dtos.CustomerProducts;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.BusinessServices.CustomerProducts
{
    public interface ICustomerProductWriteService
    {
        BaseServiceResult<CustomerProductModel> Insert(CustomerProductModel customer);
        BaseServiceResult<CustomerProductModel> Update(CustomerProductModel customer);
        BaseServiceResult<bool> Delete(long id);
    }
}
