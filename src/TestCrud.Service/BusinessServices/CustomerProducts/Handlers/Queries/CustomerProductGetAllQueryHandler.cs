using Crud.Service.Dtos.CustomerProducts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;
using TestCrud.Infrastructure.MediatRConfig.Queries;

namespace Crud.Service.BusinessServices.CustomerProducts.Handlers.Queries
{
    public partial class CustomerProductGetAllQueryHandler : IQueryHandler<BaseGetAllQuery<CustomerProductModel>, BaseServiceResult<CustomerProductModel[]>>
    {
        private readonly ICustomerProductReadService _customerReadService;

        public CustomerProductGetAllQueryHandler(ICustomerProductReadService customerReadService)
        {
            _customerReadService = customerReadService;
        }

        public Task<BaseServiceResult<CustomerProductModel[]>> Handle(BaseGetAllQuery<CustomerProductModel> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerReadService.FindAll());
        }
    }
}
