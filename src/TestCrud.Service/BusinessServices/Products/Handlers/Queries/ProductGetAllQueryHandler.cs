using Crud.Service.Dtos.CustomerProducts;
using Crud.Service.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;
using TestCrud.Infrastructure.MediatRConfig.Queries;

namespace Crud.Service.BusinessServices.Products.Handlers.Queries
{
    public partial class ProductGetAllQueryHandler : IQueryHandler<BaseGetAllQuery<ProductModel>, BaseServiceResult<ProductModel[]>>
    {
        private readonly IProductReadService _customerReadService;

        public ProductGetAllQueryHandler(IProductReadService customerReadService)
        {
            _customerReadService = customerReadService;
        }

        public Task<BaseServiceResult<ProductModel[]>> Handle(BaseGetAllQuery<ProductModel> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerReadService.FindAll());
        }
    }
}
