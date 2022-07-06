using Crud.Service.BusinessServices.CustomerProducts;
using Crud.Service.BusinessServices.CustomerProducts.Handlers.Queries;
using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;
using Xunit;

namespace Crud.Service.Test.BusinessServices.CustomerCustomerProducts.Query
{
    public class CustomerProductGetAllTest
    {
        Mock<ICustomerProductReadService> mockCustomerProductReadService;
        public CustomerProductGetAllTest()
        {
            mockCustomerProductReadService = MockCustomerProductReadService.GetService();
        }

        [Fact]
        public async Task CustomerProductGetAll_shouldHaveData()
        {
            var handler = new CustomerProductGetAllQueryHandler(mockCustomerProductReadService.Object);

            var result = await handler.Handle(new BaseGetAllQuery<CustomerProductModel>(), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
