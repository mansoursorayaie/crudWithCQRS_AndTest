using Crud.Domin.Enums;
using Crud.Service.BusinessServices.CustomerProducts.Handlers.Queries;
using Crud.Service.BusinessServices.Products;
using Crud.Service.BusinessServices.Products.Handlers.Queries;
using Crud.Service.BusinessServices.Products.Queries;
using Crud.Service.Test.Moq;
using Crud.Service.Test.Moq.Crud.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Products.Query
{
    public class GetProductsByProductTypeTest
    {
        Mock<IProductReadService> _mockProductReadService;
        public GetProductsByProductTypeTest()
        {
            _mockProductReadService = MockProductReadService.GetService();
        }

        [Theory]
        [InlineData(ProductType.Mobile)]
        [InlineData(ProductType.Laptop)]
        [InlineData(ProductType.Tablet)]
        public async Task ProductReadGetProductsByProductType_shouldHaveData(ProductType input)
        {
            var handler = new GetProductsByProductTypeHandler(_mockProductReadService.Object);

            var result = await handler.Handle(new GetProductsByProductTypeQuery(input), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
