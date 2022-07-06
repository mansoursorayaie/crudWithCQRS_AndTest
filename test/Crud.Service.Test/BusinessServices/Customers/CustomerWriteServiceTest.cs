using Crud.Domin.Entities.Customers;
using Crud.Domin.Entities.Products;
using Crud.Domin.Enums;
using Crud.Service.BusinessServices.Customers;
using Crud.Service.BusinessServices.Products;
using Crud.Service.Test.Moq;
using Crud.Service.Test.Moq.Crud.EntityCore;
using Mapster;
using MapsterMapper;
using Moq;
using Xunit;

namespace Crud.Service.Test.BusinessServices.Customers
{
    public class CustomerWriteServiceTest
    {
        Mock<ICustomerWriteRepository> _mockCustomerWriteRepository;
        Mock<ICustomerReadRepository> _mockCustomerReadRepository;
        Mock<IMapper> _mapper;
        public CustomerWriteServiceTest()
        {
            _mockCustomerWriteRepository = MockCustomerWriteRepository.GetService();
            _mockCustomerReadRepository = MockCustomerReadRepository.GetService();
            _mapper = MockMapper.GetService();
        }

        [Fact]
        public void CustomerInsert_ShouldHaveData_ShouldHaveData_ShouldBeSuccess()
        {
            var service = new CustomerWriteService(
                _mockCustomerWriteRepository.Object,
                _mockCustomerReadRepository.Object, 
                _mapper.Object);

            var result = service.Insert(MockCustomerWriteRepository.GetRequestModel());

            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public void CustomerUpdate_ShouldHaveData_ShouldHaveData_ShouldBeSuccess()
        {
            var service = new CustomerWriteService(
                _mockCustomerWriteRepository.Object,
                _mockCustomerReadRepository.Object,
                _mapper.Object);

            var result = service.Update(MockCustomerWriteRepository.GetRequestModel());

            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Data);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void CustomerDelete_ShouldHaveData_ShouldBeSuccess(long Id)
        {
            var service = new CustomerWriteService(
                _mockCustomerWriteRepository.Object,
                _mockCustomerReadRepository.Object,
                _mapper.Object);

            var result = service.Delete(Id);

            Assert.True(result.IsSuccess);
        }

        [Theory]
        [InlineData(4)]
        public void CustomerDelete_ShouldHaveData_ShouldNotBeSuccess(long Id)
        {
            var service = new CustomerWriteService(
                _mockCustomerWriteRepository.Object,
                _mockCustomerReadRepository.Object,
                _mapper.Object);

            var result = service.Delete(Id);

            Assert.False(result.IsSuccess);
        }
    }
}
