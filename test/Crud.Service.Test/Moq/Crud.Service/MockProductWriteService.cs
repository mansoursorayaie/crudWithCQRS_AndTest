using Crud.Domin.Entities.Products;
using Crud.Service.BusinessServices.Products;
using Crud.Service.Dtos.Products;
using Moq;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.Test.Moq.Crud.Service
{
    public class MockProductWriteService
    {
        public static Mock<IProductWriteService> GetService()
        {
            var mockService = new Mock<IProductWriteService>();

            mockService.Setup(r => r.Insert(It.IsAny<ProductModel>())).Returns(new BaseServiceResult<ProductModel>());
            mockService.Setup(r => r.Update(It.IsAny<ProductModel>())).Returns(new BaseServiceResult<ProductModel>());
            mockService.Setup(r => r.Delete(1)).Returns(new BaseServiceResult<bool>());

            return mockService;
        }

        internal static ProductModel GetRequestObject()
        {
            return new ProductModel();   
        }
    }
}
