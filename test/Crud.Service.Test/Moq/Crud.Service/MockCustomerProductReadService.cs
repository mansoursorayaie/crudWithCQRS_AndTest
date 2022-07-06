using Crud.Domin.Entities.CustomerProducts;
using Crud.Service.BusinessServices.CustomerProducts;
using Crud.Service.Dtos.CustomerProducts;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.Test.Moq.Crud.Service
{
    public class MockCustomerProductReadService
    {
        public static Mock<ICustomerProductReadService> GetService()
        {
            var mockService = new Mock<ICustomerProductReadService>();

            mockService.Setup(r => r.GetById(1)).Returns(new BaseServiceResult<CustomerProductModel>());
            mockService.Setup(r => r.FindAll()).Returns(new BaseServiceResult<CustomerProductModel[]>());
            mockService.Setup(r => r.GetCustomerProductsByCustomerId(1)).Returns(new BaseServiceResult<CustomerProductModel[]>());

            return mockService;
        }
    }
}
