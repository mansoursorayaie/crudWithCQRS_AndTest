using Crud.Domin.Entities.Products;
using Crud.Service.BusinessServices.Products;
using Crud.Service.Test.Moq;
using Crud.Service.Test.Moq.Crud.EntityCore;
using MapsterMapper;
using Moq;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Products
{
    public class ProductWriteServiceTest
    {
        Mock<IProductReadRepository> _mockProductReadRepository;
        Mock<IProductWriteRepository> _mockProductWriteRepository;
        Mock<IMapper> _mapper;
        public ProductWriteServiceTest()
        {
            _mockProductReadRepository = MockProductReadRepository.GetService();
            _mockProductWriteRepository = MockProductWriteRepository.GetService();
            _mapper = MockMapper.GetService();
        }

        [Fact]
        public void ProductInsert_ShouldHaveData_ShouldHaveData_ShouldBeSuccess()
        {
            var service = new ProductWriteService(_mockProductReadRepository.Object, _mockProductWriteRepository.Object, _mapper.Object);

            var result = service.Insert(MockProductWriteRepository.GetRequestModel());

            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public void ProductUpdate_ShouldHaveData_ShouldHaveData_ShouldBeSuccess()
        {
            var service = new ProductWriteService(_mockProductReadRepository.Object, _mockProductWriteRepository.Object, _mapper.Object);

            var result = service.Update(MockProductWriteRepository.GetRequestModel());

            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Data);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void ProductDelete_ShouldHaveData_ShouldBeSuccess(long Id)
        {
            var service = new ProductWriteService(_mockProductReadRepository.Object, _mockProductWriteRepository.Object, _mapper.Object);

            var result = service.Delete(Id);

            Assert.True(result.IsSuccess);
        }

        [Theory]
        [InlineData(4)]
        public void ProductDelete_ShouldHaveData_ShouldNotBeSuccess(long Id)
        {
            var service = new ProductWriteService(_mockProductReadRepository.Object, _mockProductWriteRepository.Object, _mapper.Object);

            var result = service.Delete(Id);

            Assert.False(result.IsSuccess);
        }
    }
}
