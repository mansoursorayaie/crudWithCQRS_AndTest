using Crud.Service.BusinessServices.CustomerProducts.Queries;
using Crud.Service.Dtos.CustomerProducts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.Queries;

namespace Crud.Service.BusinessServices.CustomerProducts.Handlers.Queries
{
    public class GetCustomerProductsByCustomerIdHandler : IQueryHandler<GetCustomerProductsByCustomerIdQuery, BaseServiceResult<CustomerProductModel[]>>
    {
        private readonly ICustomerProductReadService _customerProductReadService;

        public GetCustomerProductsByCustomerIdHandler(ICustomerProductReadService customerProductReadService)
        {
            _customerProductReadService = customerProductReadService;
        }

        public Task<BaseServiceResult<CustomerProductModel[]>> Handle(GetCustomerProductsByCustomerIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerProductReadService.GetCustomerProductsByCustomerId(request.CustomerId));
        }
    }
}
