using Crud.Service.BusinessServices.Customers;
using Crud.Service.BusinessServices.Customers.Handlers.Queries;
using Crud.Service.Dtos.Customers;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Customers.Query
{
    public class CustomerGetAllTest
    {
        Mock<ICustomerReadService> mockCustomerReadService;
        public CustomerGetAllTest()
        {
            mockCustomerReadService = MockCustomerReadService.GetService();
        }

        [Fact]
        public async Task CustomerGetAll_shouldHaveData()
        {
            var handler = new CustomerGetAllQueryHandler(mockCustomerReadService.Object);

            var result = await handler.Handle(new BaseGetAllQuery<CustomerModel>(), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
