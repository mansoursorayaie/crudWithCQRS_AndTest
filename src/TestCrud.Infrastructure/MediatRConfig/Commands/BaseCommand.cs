using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCrud.Infrastructure.MediatRConfig.Commands
{
    public abstract class BaseCommand<TResult> : IRequest<TResult>
    {
    }
}
