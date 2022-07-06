using Crud.Service.Dtos.CustomerProducts;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using TestCrud.Infrastructure.MediatRConfig.Commands;

namespace Crud.Service.BusinessServices.CustomerProducts.Handlers.Commands
{
    public class CustomerProductInsertCommandHandler : ICommandHandler<BaseInsertCommand<CustomerProductModel>, BaseServiceResult<CustomerProductModel>>
    {
        private readonly ICustomerProductWriteService _customerWriteService;

        public CustomerProductInsertCommandHandler(
            ICustomerProductWriteService customerWriteService)
        {
            _customerWriteService = customerWriteService;
        }

        public Task<BaseServiceResult<CustomerProductModel>> Handle(BaseInsertCommand<CustomerProductModel> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerWriteService.Insert(request.Model));
        }
    }
}
