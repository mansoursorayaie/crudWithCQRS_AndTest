using Crud.Service.BusinessServices.CustomerProducts.Queries;
using Crud.Service.Dtos.CustomerProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.Controller;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;

namespace Crud.Web.Controllers
{
    public class CustomerProductController : BaseController
    {
        private readonly IMediator _mediator;

        public CustomerProductController(
            IMediator mediator)
        {
            _mediator = mediator;
        }


        /// <summary>
        /// Get Customer by Id
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]/{customerProductId}")]
        public async Task<ActionResult<CustomerProductModel>> GetById([FromRoute] long customerProductId)
        {
            var result = await _mediator.Send(new BaseGetByIdQuery<CustomerProductModel>(customerProductId));
            return Respons(result);
        }

        /// <summary>
        /// Get All Customers
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<ActionResult<CustomerProductModel[]>> GetAll()
        {
            var result = await _mediator.Send(new BaseGetAllQuery<CustomerProductModel>());
            return Respons(result);
        }


        /// <summary>
        /// Insert a Customer
        /// </summary>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<ActionResult<CustomerProductModel>> Insert([FromBody] CustomerProductModel customerProduct)
        {
            var result = await _mediator.Send(new BaseInsertCommand<CustomerProductModel>(customerProduct));
            return Respons(result);
        }

        /// <summary>
        /// Update a Customer
        /// </summary>
        /// <returns></returns>
        [HttpPatch("[action]")]
        public async Task<ActionResult<CustomerProductModel>> Update([FromBody] CustomerProductModel customerProduct)
        {
            var result = await _mediator.Send(new BaseUpdateCommand<CustomerProductModel>(customerProduct));
            return Respons(result);
        }

        /// <summary>
        /// Delete a Customer
        /// </summary>
        /// <returns></returns>
        [HttpDelete("[action]/{customerProductId}")]
        public async Task<ActionResult<bool>> Delete([FromRoute] long customerProductId)
        {
            var result = await _mediator.Send(new BaseDeleteCommand<CustomerProductModel>(customerProductId));
            return Respons(result);
        }

        /// <summary>
        /// Get CustomerProducts of Customer
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]/{customerId}")]
        public async Task<ActionResult<CustomerProductModel[]>> GetCustomerProductsByCustomerId([FromRoute] long customerId)
        {
            var result = await _mediator.Send(new GetCustomerProductsByCustomerIdQuery(customerId));
            return Respons(result);
        }
    }
}
