using Crud.Service.BusinessServices.CustomerProducts;
using Crud.Service.BusinessServices.CustomerProducts.Handlers.Queries;
using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;
using Xunit;

namespace Crud.Service.Test.BusinessServices.CustomerCustomerProducts.Query
{
    public class CustomerProductGetByIdTest
    {
        Mock<ICustomerProductReadService> mockCustomerProductReadService;
        public CustomerProductGetByIdTest()
        {
            mockCustomerProductReadService = MockCustomerProductReadService.GetService();
        }

        [Theory]
        [InlineData(1)]
        public async Task CustomerProductReadGetCustomerProductsByCustomerProductType_shouldHaveData(long id)
        {
            var handler = new CustomerProductGetByIdQueryHandler(mockCustomerProductReadService.Object);

            var result = await handler.Handle(new BaseGetByIdQuery<CustomerProductModel>(id), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
