namespace Framework.Service
{
    public interface UtilService
    {
        void Insert(object entity);
        void Delete(object entity);
        void Update(object entity);
        object FindById(object entity, int id);
    }
}