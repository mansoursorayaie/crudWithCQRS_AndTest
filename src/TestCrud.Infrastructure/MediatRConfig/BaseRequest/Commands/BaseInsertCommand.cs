using TestCrud.Infrastructure.BaseResults;
using TestCrud.Infrastructure.MediatRConfig.Commands;

namespace TestCrud.Infrastructure.MediatRConfig.BaseRequest.Commands
{
    public class BaseInsertCommand<T> : BaseCommand<BaseServiceResult<T>>
    {
        public T Model { get; }

        public BaseInsertCommand(T model)
        {
            Model = model;
        }

    }
}
