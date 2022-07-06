using Crud.Service.BusinessServices.Customers;
using Crud.Service.BusinessServices.Customers.Handlers.Commands;
using Crud.Service.Dtos.Customers;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Customers.Command
{
    public class CustomerInsertTest
    {
        Mock<ICustomerWriteService> _mockCustomerWriteService;
        public CustomerInsertTest()
        {
            _mockCustomerWriteService = MockCustomerWriteService.GetService();
        }

        [Fact]
        public async Task CustomerBaseDeleteCommand_shouldHaveData()
        {
            var handler = new CustomerInsertCommandHandler(_mockCustomerWriteService.Object);

            var result = await handler.Handle(new BaseInsertCommand<CustomerModel>(MockCustomerWriteService.GetRequestObject()), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
