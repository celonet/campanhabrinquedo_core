using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace campanhabrinquedo.repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntitieBase
    {
        private readonly CampanhaBrinquedoContext _context;
        protected readonly DbSet<T> DbSet;

        public Repository(CampanhaBrinquedoContext context)
        {
            _context = context;
            DbSet = _context.Set<T>();
        }

        public void Create(T entitie)
        {
            DbSet.Add(entitie);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
            _context.SaveChanges();
        }

        public T FindByExpression(Func<T, bool> expression)
        {
            return DbSet.FirstOrDefault(expression);
        }

        public T FindById(Guid id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<T> List()
        {
            return DbSet;
        }

        public IEnumerable<T> List(Func<T, bool> expression)
        {
            return DbSet.Where(expression);
        }

        public void Update(T entitie)
        {
            DbSet.Update(entitie);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
