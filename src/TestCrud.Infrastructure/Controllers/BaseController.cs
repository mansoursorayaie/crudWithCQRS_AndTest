using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using TestCrud.Infrastructure.BaseResults;

namespace TestCrud.Infrastructure.Controller
{
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        public ActionResult Respons<T>(BaseServiceResult<T> result)
        {
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
