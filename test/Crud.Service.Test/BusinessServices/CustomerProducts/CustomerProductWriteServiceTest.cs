using Crud.Domin.Entities.CustomerProducts;
using Crud.Domin.Entities.Customers;
using Crud.Domin.Entities.Products;
using Crud.Domin.Enums;
using Crud.Service.BusinessServices.CustomerProducts;
using Crud.Service.BusinessServices.Products;
using Crud.Service.Test.Moq;
using Crud.Service.Test.Moq.Crud.EntityCore;
using Mapster;
using MapsterMapper;
using Moq;
using Xunit;

namespace Crud.Service.Test.BusinessServices.CustomerProducts
{
    public class CustomerProductWriteServiceTest
    {
        Mock<ICustomerProductReadRepository> _mockCustomerProductReadRepository;
        Mock<ICustomerProductWriteRepository> _mockCustomerProductWriteRepository;
        Mock<IProductReadRepository> _mockProductReadRepository;
        Mock<ICustomerReadRepository> _mockCustomerReadRepository;
        Mock<IMapper> _mapper;
        public CustomerProductWriteServiceTest()
        {
            _mockCustomerProductReadRepository = MockCustomerProductReadRepository.GetService();
            _mockCustomerProductWriteRepository = MockCustomerProductWriteRepository.GetService();
            _mockProductReadRepository = MockProductReadRepository.GetService();
            _mockCustomerReadRepository = MockCustomerReadRepository.GetService();
            _mapper = MockMapper.GetService();
        }

        [Fact]
        public void CustomerProductInsert_ShouldHaveData_ShouldHaveData_ShouldBeSuccess()
        {
            var service = new CustomerProductWriteService(
                _mockProductReadRepository.Object,
                _mockCustomerReadRepository.Object,
                _mockCustomerProductReadRepository.Object, 
                _mockCustomerProductWriteRepository.Object, 
                _mapper.Object);

            var result = service.Insert(MockCustomerProductWriteRepository.GetRequestModel());

            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public void CustomerProductUpdate_ShouldHaveData_ShouldHaveData_ShouldBeSuccess()
        {
            var service = new CustomerProductWriteService(
                _mockProductReadRepository.Object,
                _mockCustomerReadRepository.Object,
                _mockCustomerProductReadRepository.Object,
                _mockCustomerProductWriteRepository.Object,
                _mapper.Object);

            var result = service.Update(MockCustomerProductWriteRepository.GetRequestModel());

            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Data);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void CustomerProductDelete_ShouldHaveData_ShouldBeSuccess(long Id)
        {
            var service = new CustomerProductWriteService(
                _mockProductReadRepository.Object,
                _mockCustomerReadRepository.Object,
                _mockCustomerProductReadRepository.Object,
                _mockCustomerProductWriteRepository.Object,
                _mapper.Object);

            var result = service.Delete(Id);

            Assert.True(result.IsSuccess);
        }

        [Theory]
        [InlineData(4)]
        public void Delete_ShouldHaveData_ShouldNotBeSuccess(long Id)
        {
            var service = new CustomerProductWriteService(
                _mockProductReadRepository.Object,
                _mockCustomerReadRepository.Object,
                _mockCustomerProductReadRepository.Object,
                _mockCustomerProductWriteRepository.Object,
                _mapper.Object);

            var result = service.Delete(Id);

            Assert.False(result.IsSuccess);
        }
    }
}
