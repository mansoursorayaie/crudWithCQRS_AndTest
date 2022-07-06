using Crud.Service.BusinessServices.Customers;
using Crud.Service.BusinessServices.Customers.Handlers.Queries;
using Crud.Service.Dtos.Customers;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Customers.Query
{
    public class CustomerGetByIdTest
    {
        Mock<ICustomerReadService> _mockCustomerReadService;
        public CustomerGetByIdTest()
        {
            _mockCustomerReadService = MockCustomerReadService.GetService();
        }

        [Theory]
        [InlineData(1)]
        public async Task CustomerReadGetCustomersByCustomerType_shouldHaveData(long id)
        {
            var handler = new CustomerGetByIdQueryHandler(_mockCustomerReadService.Object);

            var result = await handler.Handle(new BaseGetByIdQuery<CustomerModel>(id), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
