
using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.Queries;

namespace TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries
{
    public class BaseGetByIdQuery<T> : IQuery<BaseServiceResult<T>>
    {
        public long Id;

        public BaseGetByIdQuery(long id)
        {
            Id = id;
        }
    }
}
