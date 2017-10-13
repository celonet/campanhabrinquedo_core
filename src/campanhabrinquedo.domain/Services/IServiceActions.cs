using System;
using System.Linq;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.domain.Services
{
    public interface IServiceActions<T> where T : EntityBase
    {
        void Insere(T entity);
        void Altera(T entity);
        void Deleta(Guid id);
        T RetornaPorId(Guid id);
        IQueryable<T> Lista();
        bool Existe(T entity);
    }
}