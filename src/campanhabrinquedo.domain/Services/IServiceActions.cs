using System;
using System.Linq;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.domain.Services
{
    public interface IServiceActions<T> where T : EntityBase
    {
        T Insere(T entity);
        T Altera(T entity);
        void Deleta(Guid id);
        T RetornaPorId(Guid id);
        IQueryable<T> Lista();
        bool Existe(T entity);
    }
}