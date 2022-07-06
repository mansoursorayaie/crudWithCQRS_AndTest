using Crud.Service.Dtos.Products;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;
using TestCrud.Infrastructure.MediatRConfig.Queries;

namespace Crud.Service.BusinessServices.Products.Handlers.Queries
{
    public class ProductGetByIdQueryHandler : IQueryHandler<BaseGetByIdQuery<ProductModel>, BaseServiceResult<ProductModel>>
    {
        private readonly IProductReadService _productReadService;

        public ProductGetByIdQueryHandler(IProductReadService productReadService)
        {
            _productReadService = productReadService;
        }

        public Task<BaseServiceResult<ProductModel>> Handle(BaseGetByIdQuery<ProductModel> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_productReadService.GetById(request.Id));
        }
    }
}
