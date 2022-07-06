using Crud.Service.Dtos.CustomerProducts;
using System;
using System.Collections.Generic;
using System.Text;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.Queries;

namespace Crud.Service.BusinessServices.CustomerProducts.Queries
{
    public class GetCustomerProductsByCustomerIdQuery: IQuery<BaseServiceResult<CustomerProductModel[]>>
    {

        public GetCustomerProductsByCustomerIdQuery(long customerId)
        {
            CustomerId = customerId;
        }

        public long CustomerId { get; }
    }
}
