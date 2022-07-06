using Crud.Domin.Entities.CustomerProducts;
using Crud.Domin.Entities.Customers;
using Crud.Domin.Entities.Products;
using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Dtos.Customers;
using Crud.Service.Dtos.Products;
using Mapster;
using MapsterMapper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
