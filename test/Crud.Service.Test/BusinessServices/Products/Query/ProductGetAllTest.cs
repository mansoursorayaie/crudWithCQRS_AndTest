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
    public class ProductGetAllTest
    {
        Mock<IProductReadService> mockProductReadService;
        public ProductGetAllTest()
        {
            mockProductReadService = MockProductReadService.GetService();
        }

        [Fact]
        public async Task ProductGetAll_shouldHaveData()
        {
            var handler = new ProductGetAllQueryHandler(mockProductReadService.Object);

            var result = await handler.Handle(new BaseGetAllQuery<ProductModel>(), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
