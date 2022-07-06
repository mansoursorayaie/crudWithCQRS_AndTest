using Crud.Service.BusinessServices.CustomerProducts;
using Crud.Service.BusinessServices.CustomerProducts.Handlers.Commands;
using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using Xunit;

namespace Crud.Service.Test.BusinessServices.CustomerCustomerProducts.Command
{
    public class CustomerProductDeleteTest
    {
        Mock<ICustomerProductWriteService> _mockCustomerProductWriteService;
        public CustomerProductDeleteTest()
        {
            _mockCustomerProductWriteService = MockCustomerProductWriteService.GetService();
        }

        [Theory]
        [InlineData(1)]
        public async Task CustomerProductBaseDeleteCommand_shouldHaveData(long id)
        {
            var handler = new CustomerProductDeleteCommandHandler(_mockCustomerProductWriteService.Object);

            var result = await handler.Handle(new BaseDeleteCommand<CustomerProductModel>(id), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
