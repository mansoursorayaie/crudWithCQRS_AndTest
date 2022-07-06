using Crud.Service.BusinessServices.CustomerProducts;
using Crud.Service.BusinessServices.CustomerProducts.Handlers.Commands;
using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using Xunit;

namespace Crud.Service.Test.BusinessServices.CustomerCustomerProducts.Command
{
    public class CustomerProductInsertTest
    {
        Mock<ICustomerProductWriteService> _mockCustomerProductWriteService;
        public CustomerProductInsertTest()
        {
            _mockCustomerProductWriteService = MockCustomerProductWriteService.GetService();
        }

        [Fact]
        public async Task CustomerProductBaseDeleteCommand_shouldHaveData()
        {
            var handler = new CustomerProductInsertCommandHandler(_mockCustomerProductWriteService.Object);

            var result = await handler.Handle(new BaseInsertCommand<CustomerProductModel>(MockCustomerProductWriteService.GetRequestObject()), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
