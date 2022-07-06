using Crud.Domin.Enums;
using Crud.Service.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Text;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.Queries;

namespace Crud.Service.BusinessServices.Products.Queries
{
    public class GetProductsByProductTypeQuery : IQuery<BaseServiceResult<ProductModel[]>>
    {

        public GetProductsByProductTypeQuery(ProductType productType)
        {
            ProductType = productType;
        }

        public ProductType ProductType { get; }
    }
}
