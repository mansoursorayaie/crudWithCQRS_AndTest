using Crud.Domin.Entities.Customers;
using Crud.Domin.Entities.Products;
using Crud.Domin.Enums;
using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Dtos.Products;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TestCrud.Infrastructure.BaseResults;

namespace Crud.Service.BusinessServices.Products
{
    public class ProductReadService : IProductReadService
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMapper _mapper;

        public ProductReadService(
            IProductReadRepository productReadRepository,
            IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        public BaseServiceResult<ProductModel[]> FindAll()
        {
            var result = new BaseServiceResult<ProductModel[]>();

            var products = _productReadRepository.FindAll();
            result.Data = _mapper.Map<ProductModel[]>(products);

            return result;
        }

        public BaseServiceResult<ProductModel> GetById(long id)
        {
            var result = new BaseServiceResult<ProductModel>();

            var products = _productReadRepository.GetById(id);

            if (products == null)
            {
                result.IsSuccess = false;
                result.Message = "Not Found";
                return result;
            }
            result.Data = _mapper.Map<ProductModel>(products);

            return result;
        }

        public BaseServiceResult<ProductModel[]> GetProductsByProductType(ProductType productType)
        {
            var result = new BaseServiceResult<ProductModel[]>();

            var products = _productReadRepository.GetProductsByProductType(productType);
            result.Data = _mapper.Map<ProductModel[]>(products);

            return result;
        }
    }
}
