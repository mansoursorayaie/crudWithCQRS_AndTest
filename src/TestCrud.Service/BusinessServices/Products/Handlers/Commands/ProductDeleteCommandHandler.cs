using Crud.Service.Dtos.Customers;
using Crud.Service.Dtos.Products;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using TestCrud.Infrastructure.MediatRConfig.Commands;

namespace Crud.Service.BusinessServices.Products.Handlers.Commands
{
    public class ProductDeleteCommandHandler : ICommandHandler<BaseDeleteCommand<ProductModel>, BaseServiceResult<bool>>
    {
        private readonly IProductWriteService _customerWriteService;

        public ProductDeleteCommandHandler(IProductWriteService customerWriteService)
        {
            _customerWriteService = customerWriteService;
        }

        public Task<BaseServiceResult<bool>> Handle(BaseDeleteCommand<ProductModel> request, CancellationToken cancellationToken)
        {
            return Task.FromResult( _customerWriteService.Delete(request.Id));
        }
    }
}
