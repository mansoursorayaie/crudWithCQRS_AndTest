using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCrud.Infrastructure.Validations.Models;

namespace TestCrud.Infrastructure.Validations.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if(!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Where(x => x.Value?.Errors.Count > 0)
                    .ToDictionary(x=>x.Key,x=>x.Value.Errors.Select(y=>y.ErrorMessage).ToArray());

                var errorRespons = new ErrorRespons();
                foreach(var error in errors)
                {
                    foreach (var item in error.Value)
                    {
                        errorRespons.ErrorModels.Add(new ErrorModel()
                        {
                            FieldName=error.Key,
                            Message=item
                        });
                    }
                }
                context.Result = new BadRequestObjectResult(errorRespons);
                return;
            }

            await next();
        }
    }
}
