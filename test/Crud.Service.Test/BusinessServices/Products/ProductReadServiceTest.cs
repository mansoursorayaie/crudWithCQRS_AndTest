using Crud.Domin.Entities.Products;
using Crud.Domin.Enums;
using Crud.Service.BusinessServices.Products;
using Crud.Service.Test.Moq;
using Crud.Service.Test.Moq.Crud.EntityCore;
using MapsterMapper;
using Moq;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Products
{
    public class ProductReadServiceTest
    {
        Mock<IProductReadRepository> _mockProductReadRepository;
        Mock<IMapper> _mapper;
        public ProductReadServiceTest()
        {
            _mockProductReadRepository = MockProductReadRepository.GetService();
            _mapper = MockMapper.GetService();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void ProductReadGetById_ShouldHaveData_ShouldBeSuccess(long input)
        {
            var service = new ProductReadService(_mockProductReadRepository.Object, _mapper.Object);

            var result = service.GetById(input);

            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Data);
        }

        [Theory]
        [InlineData(4)]
        public void ProductReadGetById_ShouldNotHaveData_ShouldNotBeSuccess(long input)
        {
            var service = new ProductReadService(_mockProductReadRepository.Object, _mapper.Object);

            var result = service.GetById(input);

            Assert.False(result.IsSuccess);
            Assert.Null(result.Data);
        }

        [Fact]
        public void ProductReadFind_ShouldHaveData()
        {
            var service = new ProductReadService(_mockProductReadRepository.Object, _mapper.Object);

            var result = service.FindAll();

            Assert.NotNull(result.Data);
        }

        [Theory]
        [InlineData(ProductType.Laptop)]
        [InlineData(ProductType.Mobile)]
        public void ProductReadGetProductsByProductType_ShouldHaveData(ProductType productType)
        {
            var service = new ProductReadService(_mockProductReadRepository.Object, _mapper.Object);

            var result = service.GetProductsByProductType(productType);

            Assert.NotNull(result.Data);
        }
    }
}
