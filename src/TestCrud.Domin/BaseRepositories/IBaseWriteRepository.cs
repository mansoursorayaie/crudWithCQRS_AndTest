using Crud.Domin.Entities;

namespace Crud.Domin.BaseRepositories
{
    public interface IBaseWriteRepository<T> where T : BaseEntity
    {
        T Insert(T customer);
        T Update(T customer);
        bool Delete(long id);
    }
}
