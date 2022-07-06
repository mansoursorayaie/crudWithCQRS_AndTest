using Crud.Service.BusinessServices.Customers;
using Crud.Service.Dtos.Customers;
using Moq;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.Test.Moq.Crud.Service
{
    public class MockCustomerWriteService
    {
        public static Mock<ICustomerWriteService> GetService()
        {
            var mockService = new Mock<ICustomerWriteService>();

            mockService.Setup(r => r.Insert(It.IsAny<CustomerModel>())).Returns(new BaseServiceResult<CustomerModel>());
            mockService.Setup(r => r.Update(It.IsAny<CustomerModel>())).Returns(new BaseServiceResult<CustomerModel>());
            mockService.Setup(r => r.Delete(1)).Returns(new BaseServiceResult<bool>());

            return mockService;
        }

        internal static CustomerModel GetRequestObject()
        {
            return new CustomerModel();
        }
    }
}
