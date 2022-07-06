using Crud.Domin.Entities.Customers;
using Crud.Domin.Entities.Products;
using Crud.Domin.Enums;
using Crud.Service.BusinessServices.Customers;
using Crud.Service.BusinessServices.Products;
using Crud.Service.Test.Moq;
using Crud.Service.Test.Moq.Crud.EntityCore;
using MapsterMapper;
using Moq;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Customers
{
    public class CustomerReadServiceTest
    {
        Mock<ICustomerReadRepository> _mockCustomerReadRepository;
        Mock<IMapper> _mapper;
        public CustomerReadServiceTest()
        {
            _mockCustomerReadRepository = MockCustomerReadRepository.GetService();
            _mapper = MockMapper.GetService();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void CustomerReadGetById_ShouldHaveData_ShouldBeSuccess(long input)
        {
            var service = new CustomerReadService(_mockCustomerReadRepository.Object, _mapper.Object);

            var result = service.GetById(input);

            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Data);
        }

        [Theory]
        [InlineData(4)]
        public void CustomerReadGetById_ShouldNotHaveData_ShouldNotBeSuccess(long input)
        {
            var service = new CustomerReadService(_mockCustomerReadRepository.Object, _mapper.Object);

            var result = service.GetById(input);

            Assert.False(result.IsSuccess);
            Assert.Null(result.Data);
        }

        [Fact]
        public void CustomerReadFind_ShouldHaveData()
        {
            var service = new CustomerReadService(_mockCustomerReadRepository.Object, _mapper.Object);

            var result = service.FindAll();

            Assert.NotNull(result.Data);
        }
    }
}
