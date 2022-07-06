using Crud.Service.BusinessServices.Customers;
using Crud.Service.BusinessServices.Customers.Handlers.Commands;
using Crud.Service.Dtos.Customers;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Customers.Command
{
    public class CustomerUpdateTest
    {
        Mock<ICustomerWriteService> _mockCustomerWriteService;
        public CustomerUpdateTest()
        {
            _mockCustomerWriteService = MockCustomerWriteService.GetService();
        }

        [Fact]
        public async Task CustomerBaseDeleteCommand_shouldHaveData()
        {
            var handler = new CustomerUpdateCommandHandler(_mockCustomerWriteService.Object);

            var result = await handler.Handle(new BaseUpdateCommand<CustomerModel>(MockCustomerWriteService.GetRequestObject()), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
