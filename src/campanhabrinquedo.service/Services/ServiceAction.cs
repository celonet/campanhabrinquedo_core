using System;
using System.Linq;
using campanhabrinquedo.domain.Interfaces;
using campanhabrinquedo.domain.Services;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.Application.Services
{
    public abstract class ServiceAction<T> : IServiceActions<T> where T: EntityBase
    {
        protected readonly IRepository<T> Repository;

        protected ServiceAction(IRepository<T> repository)
        {
            Repository = repository;
        }

        public void Altera(T entity)
        {
            if (!entity.IsValid()) return;
            
            Repository.Update(entity);
        }

        public void Deleta(Guid id)
        {
            Repository.Delete(id);
        }

        public abstract bool Existe(T entity);

        public void Insere(T entity)
        {
            if (!entity.IsValid()) return;
            if (Existe(entity)) return;

            Repository.Create(entity);
        }

        public IQueryable<T> Lista()
        {
            return Repository.List();
        }

        public T RetornaPorId(Guid id)
        {
            return Repository.FindById(id);
        }
    }
}
