using Crud.Service.BusinessServices.CustomerProducts;
using Crud.Service.BusinessServices.CustomerProducts.Handlers.Commands;
using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using Xunit;

namespace Crud.Service.Test.BusinessServices.CustomerCustomerProducts.Command
{
    public class CustomerProductUpdateTest
    {
        Mock<ICustomerProductWriteService> _mockCustomerProductWriteService;
        public CustomerProductUpdateTest()
        {
            _mockCustomerProductWriteService = MockCustomerProductWriteService.GetService();
        }

        [Fact]
        public async Task CustomerProductBaseDeleteCommand_shouldHaveData()
        {
            var handler = new CustomerProductUpdateCommandHandler(_mockCustomerProductWriteService.Object);

            var result = await handler.Handle(new BaseUpdateCommand<CustomerProductModel>(MockCustomerProductWriteService.GetRequestObject()), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
