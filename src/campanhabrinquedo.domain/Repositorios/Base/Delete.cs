namespace campanhabrinquedo.domain.Repositorios.Base
{
    using System;
    public interface Delete<T> where T : class
    {
        void Delete(Guid entidadeId);
    }
}