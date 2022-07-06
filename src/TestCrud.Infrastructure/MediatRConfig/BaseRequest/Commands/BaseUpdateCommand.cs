using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.Commands;

namespace TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands
{
    public class BaseUpdateCommand<T> : BaseCommand<BaseServiceResult<T>>
    {
        public T Model { get; }

        public BaseUpdateCommand(T model)
        {
            Model = model;
        }

    }
}
