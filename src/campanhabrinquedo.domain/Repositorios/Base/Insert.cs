namespace campanhabrinquedo.domain.Repositorios.Base
{
    public interface Insert<T> where T : class
    {
        void Insert(T entidade);
    }
}