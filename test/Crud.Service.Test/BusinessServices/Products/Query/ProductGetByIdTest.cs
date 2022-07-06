using Crud.Domin.Enums;
using Crud.Service.BusinessServices.Products;
using Crud.Service.BusinessServices.Products.Handlers.Queries;
using Crud.Service.BusinessServices.Products.Queries;
using Crud.Service.Dtos.Products;
using Crud.Service.Test.Moq;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Products.Query
{
    public class ProductGetByIdTest
    {
        Mock<IProductReadService> mockProductReadService;
        public ProductGetByIdTest()
        {
            mockProductReadService = MockProductReadService.GetService();
        }

        [Theory]
        [InlineData(1)]
        public async Task ProductReadGetProductsByProductType_shouldHaveData(long id)
        {
            var handler = new ProductGetByIdQueryHandler(mockProductReadService.Object);

            var result = await handler.Handle(new BaseGetByIdQuery<ProductModel>(id), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
