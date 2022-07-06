using Crud.Domin.Entities.CustomerProducts;
using Crud.EntityCore.Repositories.CustomerProducts;
using Moq;

namespace Crud.Service.Test.Moq.Crud.EntityCore
{
    public class MockCustomerProductReadRepository
    {
        public MockCustomerProductReadRepository()
        {
        }

        public static Mock<ICustomerProductReadRepository> GetService()
        {
            var customerProduct = new CustomerProduct[]{
                new CustomerProduct()
                {
                    Id = 1,
                    CustomerId=1,
                    ProductId=1,
                },
                new CustomerProduct()
                {
                    Id = 2,
                    CustomerId=2,
                    ProductId=2,
                },
                new CustomerProduct()
                {
                    Id = 3,
                    CustomerId=3,
                    ProductId=3,
                }
            };
            var mockService = new Mock<ICustomerProductReadRepository>();


            mockService.Setup(r => r.GetById(1)).Returns(customerProduct[0]);
            mockService.Setup(r => r.GetById(2)).Returns(customerProduct[1]);
            mockService.Setup(r => r.GetById(3)).Returns(customerProduct[2]);

            mockService.Setup(r => r.FindAll()).Returns(customerProduct);

            mockService.Setup(r => r.GetCustomerProductsByCustomerId(1)).Returns(customerProduct.Where(x => x.CustomerId == 1).ToArray());
            mockService.Setup(r => r.GetCustomerProductsByCustomerId(2)).Returns(customerProduct.Where(x => x.CustomerId == 2).ToArray());
            mockService.Setup(r => r.GetCustomerProductsByCustomerId(3)).Returns(customerProduct.Where(x => x.CustomerId == 3).ToArray());



            return mockService;
        }
    }
}
