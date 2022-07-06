using Crud.Service.BusinessServices.Products;
using Crud.Service.BusinessServices.Products.Handlers.Commands;
using Crud.Service.Dtos.Products;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Products.Command
{
    public class ProductInsertTest
    {
        Mock<IProductWriteService> _mockProductWriteService;
        public ProductInsertTest()
        {
            _mockProductWriteService = MockProductWriteService.GetService();
        }

        [Fact]
        public async Task ProductBaseDeleteCommand_shouldHaveData()
        {
            var handler = new ProductInsertCommandHandler(_mockProductWriteService.Object);

            var result = await handler.Handle(new BaseInsertCommand<ProductModel>(MockProductWriteService.GetRequestObject()), CancellationToken.None);

            Assert.NotNull(result);
        }
    }

}
