using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.Queries;

namespace TestCrud.Infrastructure.MediatRConfig.BaseRequest.Queries
{
    public class BaseGetAllQuery<T> : IQuery<BaseServiceResult<T[]>>
    {
        public BaseGetAllQuery()
        {
        }
    }
}
