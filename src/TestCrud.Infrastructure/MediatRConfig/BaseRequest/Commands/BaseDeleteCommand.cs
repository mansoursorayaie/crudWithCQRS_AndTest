using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.Commands;

namespace TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands
{
    public class BaseDeleteCommand<T> : BaseCommand<BaseServiceResult<bool>>
    {
        public long Id { get; }

        public BaseDeleteCommand(long id)
        {
            Id = id;
        }

    }
}
