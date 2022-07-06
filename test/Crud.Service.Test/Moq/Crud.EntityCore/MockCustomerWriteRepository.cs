using Crud.Domin.Entities.Customers;
using Crud.Service.Dtos.Customers;
using Moq;

namespace Crud.Service.Test.Moq.Crud.EntityCore
{
    public class MockCustomerWriteRepository
    {
        public MockCustomerWriteRepository()
        {
        }

        private static CustomerModel CustomerModel;
        public static CustomerModel GetRequestModel()
        {
            if (CustomerModel == null)
            {
                CustomerModel = new CustomerModel()
                {
                    Id = 1,
                };
            }
            return CustomerModel;
        }
        public static Mock<ICustomerWriteRepository> GetService()
        {
            var customers = new List<Customer>(){
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
            var mockService = new Mock<ICustomerWriteRepository>();


            mockService.Setup(r => r.Insert(It.IsAny<Customer>())).Returns((Customer customer) =>
            {
                customers.Add(customer);
                return customer;
            });
            mockService.Setup(r => r.Update(It.IsAny<Customer>())).Returns((Customer customer) =>
            {
                customers.Add(customer);
                return customer;
            });

            mockService.Setup(r => r.Delete(1)).Returns(true);
            mockService.Setup(r => r.Delete(2)).Returns(true);
            mockService.Setup(r => r.Delete(3)).Returns(true);
            mockService.Setup(r => r.Delete(4)).Returns(false);



            return mockService;
        }
    }
}
