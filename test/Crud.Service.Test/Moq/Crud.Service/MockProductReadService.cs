using Crud.Domin.Enums;
using Crud.Service.BusinessServices.CustomerProducts;
using Crud.Service.BusinessServices.Products;
using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Dtos.Products;
using Moq;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.Test.Moq.Crud.Service
{
    public class MockProductReadService
    {
        public static Mock<IProductReadService> GetService()
        {
            var mockService = new Mock<IProductReadService>();


            mockService.Setup(r => r.GetById(1)).Returns(new BaseServiceResult<ProductModel>());

            mockService.Setup(r => r.FindAll()).Returns(new BaseServiceResult<ProductModel[]>());

            mockService.Setup(r => r.GetProductsByProductType(ProductType.Mobile)).Returns(new BaseServiceResult<ProductModel[]>());
            mockService.Setup(r => r.GetProductsByProductType(ProductType.Tablet)).Returns(new BaseServiceResult<ProductModel[]>());
            mockService.Setup(r => r.GetProductsByProductType(ProductType.Laptop)).Returns(new BaseServiceResult<ProductModel[]>());



            return mockService;
        }
    }
}
