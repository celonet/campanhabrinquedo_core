﻿using campanhabrinquedo.domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using campanhabrinquedo.domain.Interfaces;

namespace campanhabrinquedo.repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly CampanhaBrinquedoContext _context;
        protected readonly DbSet<T> DbSet;

        public Repository(CampanhaBrinquedoContext context)
        {
            _context = context;
            DbSet = _context.Set<T>();
        }

        public virtual void Create(T entitie)
        {
            DbSet.Attach(entitie);
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

        public Task<T> FindByExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return DbSet.FirstOrDefaultAsync(expression);
        }

        public T FindById(Guid id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> List()
        {
            return DbSet;
        }

        public IQueryable<T> List(Func<T, bool> expression)
        {
            return DbSet.Where(expression).AsQueryable();
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
