using MediatR;

namespace TestCrud.Infrastructure.MediatRConfig.Queries
{
    public interface IQueryHandler<in TQuery, TResult> :
       IRequestHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {

    }
}
