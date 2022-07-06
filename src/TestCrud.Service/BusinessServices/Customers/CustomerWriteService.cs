using Crud.Domin.Entities.Customers;
using Crud.Service.Dtos.Customers;
using MapsterMapper;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.BusinessServices.Customers
{
    public class CustomerWriteService : ICustomerWriteService
    {
        private readonly ICustomerWriteRepository _customerWriteRepository;
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly IMapper _mapper;

        public CustomerWriteService(
            ICustomerWriteRepository customerWriteRepository,
            ICustomerReadRepository customerReadRepository,
            IMapper mapper)
        {
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
            _mapper = mapper;
        }

        public BaseServiceResult<CustomerModel> Insert(CustomerModel customer)
        {
            var result = new BaseServiceResult<CustomerModel>();

            var entity = _mapper.Map<Customer>(customer);

            _customerWriteRepository.Insert(entity);

            result.Data = _mapper.Map<CustomerModel>(entity);

            return result;
        }

        public BaseServiceResult<CustomerModel> Update(CustomerModel customer)
        {
            var result = new BaseServiceResult<CustomerModel>();

            var entity = _customerReadRepository.GetById(customer.Id);

            if (entity == null)
            {
                result.IsSuccess = false;
                result.Message = "Not Found";
                return result;
            }

            entity = _mapper.Map<Customer>(customer);

            _customerWriteRepository.Update(entity);

            result.Data = _mapper.Map<CustomerModel>(entity);

            return result;
        }

        public BaseServiceResult<bool> Delete(long id)
        {
            var result = new BaseServiceResult<bool>();

            var entity = _customerReadRepository.GetById(id);

            if (entity == null)
            {
                result.IsSuccess = false;
                result.Message = "Not Found";
                return result;
            }
            result.Data = _customerWriteRepository.Delete(id);

            return result;
        }
    }
}
