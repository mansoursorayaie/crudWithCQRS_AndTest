using Crud.Service.Dtos.Customers;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using TestCrud.Infrastructure.MediatRConfig.Commands;

namespace Crud.Service.BusinessServices.Customers.Handlers.Commands
{
    public class CustomerDeleteCommandHandler : ICommandHandler<BaseDeleteCommand<CustomerModel>, BaseServiceResult<bool>>
    {
        private readonly ICustomerWriteService _customerWriteService;

        public CustomerDeleteCommandHandler(ICustomerWriteService customerWriteService)
        {
            _customerWriteService = customerWriteService;
        }

        public Task<BaseServiceResult<bool>> Handle(BaseDeleteCommand<CustomerModel> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerWriteService.Delete(request.Id));
        }
    }
}
