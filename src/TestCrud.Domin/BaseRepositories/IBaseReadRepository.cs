using Crud.Domin.Entities;

namespace Crud.Domin.BaseRepositories
{
    public interface IBaseReadRepository<T> where T : BaseEntity
    {
        T[] FindAll();
        T GetById(long id);
    }
}
