namespace Framework.Service
{
    public abstract class BaseService
    {
        protected abstract System.Data.IDbConnection getConnection
        {
            get;
        }
    }
}