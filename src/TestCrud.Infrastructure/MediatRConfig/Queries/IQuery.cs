using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCrud.Infrastructure.MediatRConfig.Queries
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {

    }
}
