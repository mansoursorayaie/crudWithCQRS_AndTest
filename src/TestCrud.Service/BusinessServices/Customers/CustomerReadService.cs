using Crud.Domin.Entities.Customers;
using Crud.Service.Dtos.Customers;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.BusinessServices.Customers
{
    public class CustomerReadService : ICustomerReadService
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly IMapper _mapper;

        public CustomerReadService(
            ICustomerReadRepository customerReadRepository,
            IMapper mapper)
        {
            _customerReadRepository = customerReadRepository;
            _mapper = mapper;
        }

        public BaseServiceResult<CustomerModel[]> FindAll()
        {
            var result = new BaseServiceResult<CustomerModel[]>();

            var customers = _customerReadRepository.FindAll();
            result.Data = _mapper.Map<CustomerModel[]>(customers);

            return result;
        }

        public BaseServiceResult<CustomerModel> GetById(long id)
        {
            var result = new BaseServiceResult<CustomerModel>();

            var customer = _customerReadRepository.GetById(id);

            if (customer == null)
            {
                result.IsSuccess = false;
                result.Message = "Not Found";
                return result;
            }
            result.Data = _mapper.Map<CustomerModel>(customer);

            return result;
        }
    }
}
