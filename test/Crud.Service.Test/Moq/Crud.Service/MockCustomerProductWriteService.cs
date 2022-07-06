using Crud.Service.BusinessServices.CustomerProducts;
using Crud.Service.Dtos.CustomerProducts;
using Moq;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.Test.Moq.Crud.Service
{
    public class MockCustomerProductWriteService
    {
        public static Mock<ICustomerProductWriteService> GetService()
        {
            var mockService = new Mock<ICustomerProductWriteService>();

            mockService.Setup(r => r.Insert(It.IsAny<CustomerProductModel>())).Returns(new BaseServiceResult<CustomerProductModel>());
            mockService.Setup(r => r.Update(It.IsAny<CustomerProductModel>())).Returns(new BaseServiceResult<CustomerProductModel>());
            mockService.Setup(r => r.Delete(1)).Returns(new BaseServiceResult<bool>());

            return mockService;
        }

        internal static CustomerProductModel GetRequestObject()
        {
            return new CustomerProductModel();
        }
    }
}
