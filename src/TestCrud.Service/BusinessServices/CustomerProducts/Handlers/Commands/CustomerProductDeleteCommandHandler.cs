using Crud.Service.Dtos.CustomerProducts;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using TestCrud.Infrastructure.MediatRConfig.Commands;

namespace Crud.Service.BusinessServices.CustomerProducts.Handlers.Commands
{
    public class CustomerProductDeleteCommandHandler : ICommandHandler<BaseDeleteCommand<CustomerProductModel>, BaseServiceResult<bool>>
    {
        private readonly ICustomerProductWriteService _customerProductWriteService;

        public CustomerProductDeleteCommandHandler(ICustomerProductWriteService customerProductWriteService)
        {
            _customerProductWriteService = customerProductWriteService;
        }

        public Task<BaseServiceResult<bool>> Handle(BaseDeleteCommand<CustomerProductModel> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerProductWriteService.Delete(request.Id));
        }
    }
}
