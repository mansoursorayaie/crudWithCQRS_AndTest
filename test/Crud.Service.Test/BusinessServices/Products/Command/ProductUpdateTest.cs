using Crud.Service.BusinessServices.Products;
using Crud.Service.BusinessServices.Products.Handlers.Commands;
using Crud.Service.Dtos.Products;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Products.Command
{

    public class ProductUpdateTest
    {
        Mock<IProductWriteService> _mockProductWriteService;
        public ProductUpdateTest()
        {
            _mockProductWriteService = MockProductWriteService.GetService();
        }

        [Fact]
        public async Task ProductBaseDeleteCommand_shouldHaveData()
        {
            var handler = new ProductUpdateCommandHandler(_mockProductWriteService.Object);

            var result = await handler.Handle(new BaseUpdateCommand<ProductModel>(MockProductWriteService.GetRequestObject()), CancellationToken.None);

            Assert.NotNull(result);
        }
    }

}
