using Crud.Service.Dtos.Products;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using TestCrud.Infrastructure.MediatRConfig.Commands;

namespace Crud.Service.BusinessServices.Products.Handlers.Commands
{
    public class ProductUpdateCommandHandler : ICommandHandler<BaseUpdateCommand<ProductModel>, BaseServiceResult<ProductModel>>
    {
        private readonly IProductWriteService _customerWriteService;

        public ProductUpdateCommandHandler(IProductWriteService customerWriteService)
        {
            _customerWriteService = customerWriteService;
        }

        public Task<BaseServiceResult<ProductModel>> Handle(BaseUpdateCommand<ProductModel> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerWriteService.Update(request.Model));
        }
    }
}
