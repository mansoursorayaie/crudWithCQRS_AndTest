using Crud.Domin.Entities.CustomerProducts;
using Crud.Domin.Enums;
using Crud.Service.BusinessServices.CustomerProducts;
using Crud.Service.Test.Moq;
using Crud.Service.Test.Moq.Crud.EntityCore;
using MapsterMapper;
using Moq;
using Xunit;

namespace Crud.Service.Test.BusinessServices.CustomerProducts
{
    public class CustomerProductReadServiceTest
    {
        Mock<ICustomerProductReadRepository> _mockCustomerProductReadRepository;
        Mock<IMapper> _mapper;
        public CustomerProductReadServiceTest()
        {
            _mockCustomerProductReadRepository = MockCustomerProductReadRepository.GetService();
            _mapper = MockMapper.GetService();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void CustomerProductReadGetById_ShouldHaveData_ShouldBeSuccess(long input)
        {
            var service = new CustomerProductReadService(_mockCustomerProductReadRepository.Object, _mapper.Object);

            var result = service.GetById(input);

            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Data);
        }

        [Theory]
        [InlineData(4)]
        public void CustomerProductReadGetById_ShouldNotHaveData_ShouldNotBeSuccess(long input)
        {
            var service = new CustomerProductReadService(_mockCustomerProductReadRepository.Object, _mapper.Object);

            var result = service.GetById(input);

            Assert.False(result.IsSuccess);
            Assert.Null(result.Data);
        }

        [Fact]
        public void CustomerProductReadFind_ShouldHaveData()
        {
            var service = new CustomerProductReadService(_mockCustomerProductReadRepository.Object, _mapper.Object);

            var result = service.FindAll();

            Assert.NotNull(result.Data);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void GetCustomerProductsByCustomerId_ShouldHaveData(long Id)
        {
            var service = new CustomerProductReadService(_mockCustomerProductReadRepository.Object, _mapper.Object);

            var result = service.GetCustomerProductsByCustomerId(Id);

            Assert.NotNull(result.Data);
        }
    }
}
