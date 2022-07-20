using Crud.Domin.Entities.CustomerProducts;
using Crud.Service.Dtos.CustomerProducts;
using Moq;

namespace Crud.Service.Test.Moq.Crud.EntityCore
{
    public class MockCustomerProductWriteRepository
    {
        public MockCustomerProductWriteRepository()
        {
        }

        private static CustomerProductModel ProductModel;

        public static CustomerProductModel GetRequestModel()
        {
            if (ProductModel == null)
            {
                ProductModel = new CustomerProductModel()
                {
                    Id = 1,
                    CustomerId = 1,
                    ProductId = 1,
                };
            }
            return ProductModel;
        }
        public static Mock<ICustomerProductWriteRepository> GetService()
        {
            var products = new List<CustomerProduct>(){
                new CustomerProduct()
                {
                    Id = 1,
                },
                new CustomerProduct()
                {
                    Id = 2,
                },
                new CustomerProduct()
                {
                    Id = 3,
                }
            };
            var mockService = new Mock<ICustomerProductWriteRepository>();


            mockService.Setup(r => r.Insert(It.IsAny<CustomerProduct>())).Returns((CustomerProduct product) =>
            {
                products.Add(product);
                return product;
            });
            mockService.Setup(r => r.Update(It.IsAny<CustomerProduct>())).Returns((CustomerProduct product) =>
            {
                products.Add(product);
                return product;
            });

            mockService.Setup(r => r.Delete(1)).Returns(true);
            mockService.Setup(r => r.Delete(2)).Returns(true);
            mockService.Setup(r => r.Delete(3)).Returns(true);
            mockService.Setup(r => r.Delete(4)).Returns(false);



            return mockService;
        }
    }
}
