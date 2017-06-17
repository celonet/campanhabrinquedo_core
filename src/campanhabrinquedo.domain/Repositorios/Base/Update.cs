namespace campanhabrinquedo.domain.Repositorios.Base
{
    public interface Update<T> where T : class
    {
        void Update(T entidade);
    }
}