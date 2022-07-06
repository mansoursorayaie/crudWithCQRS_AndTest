using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Dtos.Products;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.BusinessServices.Products
{
    public interface IProductWriteService
    {
        BaseServiceResult<ProductModel> Insert(ProductModel customer);
        BaseServiceResult<ProductModel> Update(ProductModel customer);
        BaseServiceResult<bool> Delete(long id);
    }
}
