using Crud.Service.BusinessServices.Products;
using Crud.Service.BusinessServices.Products.Handlers.Commands;
using Crud.Service.Dtos.Products;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Products.Command
{
    public class ProductDeleteTest
    {
        Mock<IProductWriteService> _mockProductWriteService;
        public ProductDeleteTest()
        {
            _mockProductWriteService = MockProductWriteService.GetService();
        }

        [Theory]
        [InlineData(1)]
        public async Task ProductBaseDeleteCommand_shouldHaveData(long id)
        {
            var handler = new ProductDeleteCommandHandler(_mockProductWriteService.Object);

            var result = await handler.Handle(new BaseDeleteCommand<ProductModel>(id), CancellationToken.None);

            Assert.NotNull(result);
        }
    }

}
