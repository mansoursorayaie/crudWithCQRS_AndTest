using Crud.Domin.Entities.CustomerProducts;
using Crud.Domin.Entities.Customers;
using Crud.Domin.Entities.Products;
using Crud.Service.Dtos.CustomerProducts;
using MapsterMapper;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.BusinessServices.CustomerProducts
{
    public class CustomerProductWriteService : ICustomerProductWriteService
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerProductReadRepository _customerProductReadRepository;
        private readonly ICustomerProductWriteRepository _customerProductWriteRepository;
        private readonly IMapper _mapper;

        public CustomerProductWriteService(
            IProductReadRepository productReadRepository,
            ICustomerReadRepository customerReadRepository,
            ICustomerProductReadRepository customerProductReadRepository,
            ICustomerProductWriteRepository customerProductWriteRepository,
            IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _customerReadRepository = customerReadRepository;
            _customerProductReadRepository = customerProductReadRepository;
            _customerProductWriteRepository = customerProductWriteRepository;
            _mapper = mapper;
        }

        public BaseServiceResult<CustomerProductModel> Insert(CustomerProductModel customerProductModel)
        {
            var result = new BaseServiceResult<CustomerProductModel>();

            var product = _productReadRepository.GetById(customerProductModel.ProductId);

            if (product == null)
            {
                result.IsSuccess = false;
                result.Message = "product Not Found";
                return result;
            }

            var customer = _customerReadRepository.GetById(customerProductModel.CustomerId);

            if (customer == null)
            {
                result.IsSuccess = false;
                result.Message = "customer Not Found";
                return result;
            }

            var entity = _mapper.Map<CustomerProduct>(customerProductModel);

            _customerProductWriteRepository.Insert(entity);

            result.Data = _mapper.Map<CustomerProductModel>(entity);


            return result;
        }

        public BaseServiceResult<CustomerProductModel> Update(CustomerProductModel customerProductModel)
        {
            var result = new BaseServiceResult<CustomerProductModel>();

            var customerProduct = _customerProductReadRepository.GetById(customerProductModel.Id);
            if (customerProduct == null)
            {
                result.IsSuccess = false;
                result.Message = "Not Found";
                return result;
            }

            var product = _productReadRepository.GetById(customerProductModel.ProductId);

            if (product == null)
            {
                result.IsSuccess = false;
                result.Message = "product Not Found";
                return result;
            }

            var customer = _customerReadRepository.GetById(customerProductModel.CustomerId);

            if (customer == null)
            {
                result.IsSuccess = false;
                result.Message = "customer Not Found";
                return result;
            }

            var entity = _mapper.Map<CustomerProduct>(customerProductModel);

            _customerProductWriteRepository.Update(entity);

            result.Data = _mapper.Map<CustomerProductModel>(entity);


            return result;
        }

        public BaseServiceResult<bool> Delete(long id)
        {
            var result = new BaseServiceResult<bool>();

            var entity = _customerProductReadRepository.GetById(id);

            if (entity == null)
            {
                result.IsSuccess = false;
                result.Message = "Not Found";
                return result;
            }
            result.Data = _customerProductWriteRepository.Delete(id);

            return result;
        }
    }
}
