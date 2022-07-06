using Crud.Service.BusinessServices.Customers;
using Crud.Service.BusinessServices.Customers.Handlers.Commands;
using Crud.Service.Dtos.Customers;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Customers.Command
{
    public class CustomerDeleteTest
    {
        Mock<ICustomerWriteService> _mockCustomerWriteService;
        public CustomerDeleteTest()
        {
            _mockCustomerWriteService = MockCustomerWriteService.GetService();
        }

        [Theory]
        [InlineData(1)]
        public async Task CustomerBaseDeleteCommand_shouldHaveData(long id)
        {
            var handler = new CustomerDeleteCommandHandler(_mockCustomerWriteService.Object);

            var result = await handler.Handle(new BaseDeleteCommand<CustomerModel>(id), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
