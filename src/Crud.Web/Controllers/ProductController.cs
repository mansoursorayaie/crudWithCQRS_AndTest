using Crud.Domin.Enums;
using Crud.Service.BusinessServices.Products.Queries;
using Crud.Service.Dtos.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestCrud.Infrastructure.Controller;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;

namespace Crud.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IMediator _mediator;

        public ProductController(
            IMediator mediator)
        {
            _mediator = mediator;
        }


        /// <summary>
        /// Get Customer by Id
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]/{productId}")]
        public async Task<ActionResult<ProductModel>> GetById([FromRoute] long productId)
        {
            var result = await _mediator.Send(new BaseGetByIdQuery<ProductModel>(productId));
            return Respons(result);
        }

        /// <summary>
        /// Get All Customers
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<ActionResult<ProductModel[]>> GetAll()
        {
            var result = await _mediator.Send(new BaseGetAllQuery<ProductModel>());
            return Respons(result);
        }


        /// <summary>
        /// Insert a Customer
        /// </summary>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<ActionResult<ProductModel>> Insert([FromBody] ProductModel product)
        {
            var result = await _mediator.Send(new BaseInsertCommand<ProductModel>(product));
            return Respons(result);
        }

        /// <summary>
        /// Update a Customer
        /// </summary>
        /// <returns></returns>
        [HttpPatch("[action]")]
        public async Task<ActionResult<ProductModel>> Update([FromBody] ProductModel product)
        {
            var result = await _mediator.Send(new BaseUpdateCommand<ProductModel>(product));
            return Respons(result);
        }

        /// <summary>
        /// Delete a Customer
        /// </summary>
        /// <returns></returns>
        [HttpDelete("[action]/{productId}")]
        public async Task<ActionResult<bool>> Delete([FromRoute] long productId)
        {
            var result = await _mediator.Send(new BaseDeleteCommand<ProductModel>(productId));
            return Respons(result);
        }

        /// <summary>
        /// Get CustomerProducts of Customer
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]/{productType}")]
        public async Task<ActionResult<ProductModel[]>> GetProductsByProductType([FromRoute] ProductType productType)
        {
            var result = await _mediator.Send(new GetProductsByProductTypeQuery(productType));
            return Respons(result);
        }
    }
}
