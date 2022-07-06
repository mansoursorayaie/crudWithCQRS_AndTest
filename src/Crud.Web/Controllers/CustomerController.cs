using Crud.Service.Dtos.Customers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestCrud.Infrastructure.Controller;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands;
using TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries;

namespace Crud.Web.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly IMediator _mediator;

        public CustomerController(
            IMediator mediator)
        {
            _mediator = mediator;
        }


        /// <summary>
        /// Get Customer by Id
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]/{CustomerId}")]
        public async Task<ActionResult<CustomerModel>> GetById([FromRoute] long CustomerId)
        {
            var result = await _mediator.Send(new BaseGetByIdQuery<CustomerModel>(CustomerId));
            return Respons(result);
        }

        /// <summary>
        /// Get All Customers
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<ActionResult<CustomerModel[]>> GetAll()
        {
            var result = await _mediator.Send(new BaseGetAllQuery<CustomerModel>());
            return Respons(result);
        }


        /// <summary>
        /// Insert a Customer
        /// </summary>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<ActionResult<CustomerModel>> Insert([FromBody] CustomerModel customerModel)
        {
            var result = await _mediator.Send(new BaseInsertCommand<CustomerModel>(customerModel));
            return Respons(result);
        }

        /// <summary>
        /// Update a Customer
        /// </summary>
        /// <returns></returns>
        [HttpPatch("[action]")]
        public async Task<ActionResult<CustomerModel>> Update([FromBody] CustomerModel customerModel)
        {
            var result = await _mediator.Send(new BaseUpdateCommand<CustomerModel>(customerModel));
            return Respons(result);
        }

        /// <summary>
        /// Delete a Customer
        /// </summary>
        /// <returns></returns>
        [HttpDelete("[action]/{customerId}")]
        public async Task<ActionResult<bool>> Delete([FromRoute] long customerId)
        {
            var result = await _mediator.Send(new BaseDeleteCommand<CustomerModel>(customerId));
            return Respons(result);
        }


    }
}
