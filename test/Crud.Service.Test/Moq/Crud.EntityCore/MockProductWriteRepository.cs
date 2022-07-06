using Crud.Domin.Entities.Products;
using Crud.Domin.Enums;
using Crud.Service.Dtos.Products;
using Moq;

namespace Crud.Service.Test.Moq.Crud.EntityCore
{
    public class MockProductWriteRepository
    {
        public MockProductWriteRepository()
        {
        }
        private static ProductModel ProductModel;
        public static ProductModel GetRequestModel()
        {
            if (ProductModel == null)
            {
                ProductModel = new ProductModel()
                {
                    Id = 1,
                    Name = "S11",
                    ProductType = ProductType.Tablet,
                };
            }
            return ProductModel;
        }
        public static Mock<IProductWriteRepository> GetService()
        {
            var products = new List<Product>(){
                new Product()
                {
                    Id = 1,
                    Name ="S21",
                    ProductType= ProductType.Mobile
                },
                new Product()
                {
                    Id = 2,
                    Name = "Vaio",
                    ProductType = ProductType.Laptop
                },
                new Product()
                {
                    Id = 3,
                    Name = "Tab 12",
                    ProductType = ProductType.Tablet
                }
            };
            var mockService = new Mock<IProductWriteRepository>();


            mockService.Setup(r => r.Insert(It.IsAny<Product>())).Returns((Product product) =>
            {
                products.Add(product);
                return product;
            });
            mockService.Setup(r => r.Update(It.IsAny<Product>())).Returns((Product product) =>
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
