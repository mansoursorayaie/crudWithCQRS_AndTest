using Crud.Service.Dtos.Customers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;
using TestCrud.Infrastructure.MediatRConfig.Queries;

namespace Crud.Service.BusinessServices.Customers.Handlers.Queries
{
    public partial class CustomerGetAllQueryHandler : IQueryHandler<BaseGetAllQuery<CustomerModel>, BaseServiceResult<CustomerModel[]>>
    {
        private readonly ICustomerReadService _customerReadService;

        public CustomerGetAllQueryHandler(ICustomerReadService customerReadService)
        {
            _customerReadService = customerReadService;
        }

        public Task<BaseServiceResult<CustomerModel[]>> Handle(BaseGetAllQuery<CustomerModel> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerReadService.FindAll());
        }
    }
}
