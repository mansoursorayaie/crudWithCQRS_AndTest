namespace Crud.Data.DataBase
{
    public interface IDbCrud
    {
        DbCrud DbContext { get; }
        void EnsureCreated();
    }
}
