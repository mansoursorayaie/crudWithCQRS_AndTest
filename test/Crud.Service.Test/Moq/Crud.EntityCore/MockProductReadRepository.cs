using Crud.Domin.Entities.Products;
using Crud.Domin.Enums;
using Moq;

namespace Crud.Service.Test.Moq.Crud.EntityCore
{
    public class MockProductReadRepository
    {
        public MockProductReadRepository()
        {
        }

        public static Mock<IProductReadRepository> GetService()
        {
            var products = new Product[]{
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
            var mockService = new Mock<IProductReadRepository>();


            mockService.Setup(r => r.GetById(1)).Returns(products[0]);
            mockService.Setup(r => r.GetById(2)).Returns(products[1]);
            mockService.Setup(r => r.GetById(3)).Returns(products[2]);

            mockService.Setup(r => r.FindAll()).Returns(products);

            mockService.Setup(r => r.GetProductsByProductType(ProductType.Mobile)).Returns(products.Where(x=>x.ProductType==ProductType.Mobile).ToArray());
            mockService.Setup(r => r.GetProductsByProductType(ProductType.Laptop)).Returns(products.Where(x=>x.ProductType==ProductType.Laptop).ToArray());
            mockService.Setup(r => r.GetProductsByProductType(ProductType.Tablet)).Returns(products.Where(x=>x.ProductType==ProductType.Tablet).ToArray());



            return mockService;
        }
    }
}
