using Crud.Domin.Entities.Customers;
using Crud.Domin.Entities.Products;
using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Dtos.Products;
using MapsterMapper;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.BusinessServices.Products
{
    public class ProductWriteService : IProductWriteService
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IMapper _mapper;

        public ProductWriteService(
            IProductReadRepository productReadRepository,
            IProductWriteRepository productWriteRepository,
            IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _mapper = mapper;
        }

        public BaseServiceResult<ProductModel> Insert(ProductModel productModel)
        {
            var result = new BaseServiceResult<ProductModel>();

            var entity = _mapper.Map<Product>(productModel);

            _productWriteRepository.Insert(entity);

            result.Data = _mapper.Map<ProductModel>(entity);

            return result;
        }

        public BaseServiceResult<ProductModel> Update(ProductModel productModel)
        {
            var result = new BaseServiceResult<ProductModel>();

            var entity = _productReadRepository.GetById(productModel.Id);

            if (entity == null)
            {
                result.IsSuccess = false;
                result.Message = "Not Found";
                return result;
            }

            entity = _mapper.Map<Product>(productModel);

            _productWriteRepository.Update(entity);

            result.Data = _mapper.Map<ProductModel>(entity);

            return result;
        }

        public BaseServiceResult<bool> Delete(long id)
        {
            var result = new BaseServiceResult<bool>();

            var entity = _productReadRepository.GetById(id);

            if (entity == null)
            {
                result.IsSuccess = false;
                result.Message = "Not Found";
                return result;
            }
            result.Data = _productWriteRepository.Delete(id);

            return result;
        }
    }
}
