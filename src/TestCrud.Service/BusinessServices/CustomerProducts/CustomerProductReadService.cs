using Crud.Domin.Entities.CustomerProducts;
using Crud.Domin.Entities.Customers;
using Crud.Service.Dtos.CustomerProducts;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.BusinessServices.CustomerProducts
{
    public class CustomerProductReadService : ICustomerProductReadService
    {
        private readonly ICustomerProductReadRepository _customerProductReadRepository;
        private readonly IMapper _mapper;

        public CustomerProductReadService(
            ICustomerProductReadRepository customerProductReadRepository,
            IMapper mapper)
        {
            _customerProductReadRepository = customerProductReadRepository;
            _mapper = mapper;
        }

        public BaseServiceResult<CustomerProductModel[]> FindAll()
        {
            var result = new BaseServiceResult<CustomerProductModel[]>();

            var customerProduct = _customerProductReadRepository.FindAll();
            result.Data = _mapper.Map<CustomerProductModel[]>(customerProduct);

            return result;
        }

        public BaseServiceResult<CustomerProductModel> GetById(long id)
        {
            var result = new BaseServiceResult<CustomerProductModel>();

            var customer = _customerProductReadRepository.GetById(id);

            if (customer == null)
            {
                result.IsSuccess = false;
                result.Message = "Not Found";
                return result;
            }
            result.Data = _mapper.Map<CustomerProductModel>(customer);

            return result;
        }

        public BaseServiceResult<CustomerProductModel[]> GetCustomerProductsByCustomerId(long customerId)
        {
            var result = new BaseServiceResult<CustomerProductModel[]>();

            var customerProduct = _customerProductReadRepository.GetCustomerProductsByCustomerId(customerId);
            result.Data = _mapper.Map<CustomerProductModel[]>(customerProduct);

            return result;
        }
    }
}
