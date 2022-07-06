using Crud.Service.Dtos.CustomerProducts;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;
using TestCrud.Infrastructure.MediatRConfig.Queries;

namespace Crud.Service.BusinessServices.CustomerProducts.Handlers.Queries
{
    public class CustomerProductGetByIdQueryHandler : IQueryHandler<BaseGetByIdQuery<CustomerProductModel>, BaseServiceResult<CustomerProductModel>>
    {
        private readonly ICustomerProductReadService _productReadService;

        public CustomerProductGetByIdQueryHandler(ICustomerProductReadService productReadService)
        {
            _productReadService = productReadService;
        }

        public Task<BaseServiceResult<CustomerProductModel>> Handle(BaseGetByIdQuery<CustomerProductModel> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_productReadService.GetById(request.Id));
        }
    }
}
