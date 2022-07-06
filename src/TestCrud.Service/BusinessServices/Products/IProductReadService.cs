using Crud.Domin.Enums;
using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Dtos.Products;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.BusinessServices.Products
{
    public interface IProductReadService
    {
        BaseServiceResult<ProductModel[]> FindAll();
        BaseServiceResult<ProductModel> GetById(long id);
        BaseServiceResult<ProductModel[]> GetProductsByProductType(ProductType productType);
    }
}
