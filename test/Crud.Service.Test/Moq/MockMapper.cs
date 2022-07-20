using Crud.Domin.Entities.CustomerProducts;
using Crud.Domin.Entities.Customers;
using Crud.Domin.Entities.Products;
using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Dtos.Customers;
using Crud.Service.Dtos.Products;
using MapsterMapper;
using Moq;

namespace Crud.Service.Test.Moq
{
    public class MockMapper
    {
        public static Mock<IMapper> GetService()
        {
            var mockService = new Mock<IMapper>();

            mockService.Setup(x => x.Map<ProductModel>(It.IsAny<Product>())).Returns(new ProductModel());
            mockService.Setup(x => x.Map<CustomerModel>(It.IsAny<Customer>())).Returns(new CustomerModel());
            mockService.Setup(x => x.Map<CustomerProductModel>(It.IsAny<CustomerProduct>())).Returns(new CustomerProductModel());

            return mockService;
        }
    }
}
