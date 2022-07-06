using Crud.Service.BusinessServices.Customers;
using Crud.Service.Dtos.Customers;
using Moq;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.Test.Moq.Crud.Service
{
    public class MockCustomerReadService
    {
        public static Mock<ICustomerReadService> GetService()
        {
            var mockService = new Mock<ICustomerReadService>();


            mockService.Setup(r => r.GetById(1)).Returns(new BaseServiceResult<CustomerModel>());
            mockService.Setup(r => r.FindAll()).Returns(new BaseServiceResult<CustomerModel[]>());

            return mockService;
        }
    }
}
