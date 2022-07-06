using Crud.Service.Dtos.Customers;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using TestCrud.Infrastructure.MediatRConfig.Commands;

namespace Crud.Service.BusinessServices.Customers.Handlers.Commands
{
    public class CustomerUpdateCommandHandler : ICommandHandler<BaseUpdateCommand<CustomerModel>, BaseServiceResult<CustomerModel>>
    {
        private readonly ICustomerWriteService _customerWriteService;

        public CustomerUpdateCommandHandler(ICustomerWriteService customerWriteService)
        {
            _customerWriteService = customerWriteService;
        }

        public Task<BaseServiceResult<CustomerModel>> Handle(BaseUpdateCommand<CustomerModel> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerWriteService.Update(request.Model));

            
        }
    }
}
