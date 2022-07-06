using Crud.Service.BusinessServices.CustomerProducts;
using Crud.Service.BusinessServices.CustomerProducts.Handlers.Queries;
using Crud.Service.BusinessServices.CustomerProducts.Queries;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using Xunit;

namespace Crud.Service.Test.BusinessServices.CustomerCustomerProducts.Query
{
    public class GetProductsByProductTypeTest
    {
        Mock<ICustomerProductReadService> _mockCustomerProductReadService;
        public GetProductsByProductTypeTest()
        {
            _mockCustomerProductReadService = MockCustomerProductReadService.GetService();
        }

        [Theory]
        [InlineData(1)]
        public async Task GetCustomerProductsByCustomerId_shouldHaveData(long id)
        {
            var handler = new GetCustomerProductsByCustomerIdHandler(_mockCustomerProductReadService.Object);

            var result = await handler.Handle(new GetCustomerProductsByCustomerIdQuery(id), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
