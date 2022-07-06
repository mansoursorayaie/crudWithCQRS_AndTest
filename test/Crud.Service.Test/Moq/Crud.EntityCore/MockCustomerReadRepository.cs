using Crud.Domin.Entities.Customers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Service.Test.Moq.Crud.EntityCore
{
    public class MockCustomerReadRepository
    {
        public MockCustomerReadRepository()
        {
        }
        public static Mock<ICustomerReadRepository> GetService()
        {
            var customers = new Customer[]{
                new Customer()
                {
                    Id = 1,
                },
                new Customer()
                {
                    Id = 2,
                },
                new Customer()
                {
                    Id = 3,
                }
            };
            var mockService = new Mock<ICustomerReadRepository>();


            mockService.Setup(r => r.GetById(1)).Returns(customers[0]);
            mockService.Setup(r => r.GetById(2)).Returns(customers[1]);
            mockService.Setup(r => r.GetById(3)).Returns(customers[2]);

            mockService.Setup(r => r.FindAll()).Returns(customers);

            return mockService;
        }
    }
}
