using Crud.Service.Dtos.Customers;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;
using TestCrud.Infrastructure.MediatRConfig.Queries;

namespace Crud.Service.BusinessServices.Customers.Handlers.Queries
{
    public class CustomerGetByIdQueryHandler : IQueryHandler<BaseGetByIdQuery<CustomerModel>, BaseServiceResult<CustomerModel>>
    {
        private readonly ICustomerReadService _customerReadService;

        public CustomerGetByIdQueryHandler(ICustomerReadService customerReadService)
        {
            _customerReadService = customerReadService;
        }

        public Task<BaseServiceResult<CustomerModel>> Handle(BaseGetByIdQuery<CustomerModel> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerReadService.GetById(request.Id));
        }
    }
}
