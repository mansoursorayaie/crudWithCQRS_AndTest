using MediatR;

namespace TestCrud.Infrastructure.MediatRConfig.Commands
{
    public interface ICommandHandler<in TCommand, TResult> : IRequestHandler<TCommand, TResult>
        where TCommand : BaseCommand<TResult>
    {

    }
}
