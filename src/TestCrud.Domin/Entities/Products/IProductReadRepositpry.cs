using Crud.Domin.BaseRepositories;
using Crud.Domin.Enums;

namespace Crud.Domin.Entities.Products
{
    public interface IProductReadRepository : IBaseReadRepository<Product>
    {
        Product[] GetProductsByProductType(ProductType productType);
    }
}
