using Crud.Service.BusinessServices.Products.Queries;
using Crud.Service.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.Queries;

namespace Crud.Service.BusinessServices.Products.Handlers.Queries
{
    public class GetProductsByProductTypeHandler : IQueryHandler<GetProductsByProductTypeQuery, BaseServiceResult<ProductModel[]>>
    {
        private readonly IProductReadService _productReadService;

        public GetProductsByProductTypeHandler(IProductReadService productReadService)
        {
            _productReadService = productReadService;
        }

        public Task<BaseServiceResult<ProductModel[]>> Handle(GetProductsByProductTypeQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_productReadService.GetProductsByProductType(request.ProductType));
        }
    }
}
