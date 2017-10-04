using System;
using System.Linq;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class ComunidadeRepository : IComunidadeRepository
    {
        private CampanhaBrinquedoContext _context;

        public ComunidadeRepository(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        public void Create(Comunidade entidade)
        {
            _context.Comunidade.Add(entidade);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var comunidade = _context.Comunidade.Find(id);
            if (comunidade != null)
            {
                _context.Comunidade.Remove(comunidade);
                _context.SaveChanges();
            }
        }

        public Comunidade FindByExpression(Func<Comunidade, bool> expression)
        {
            return _context.Comunidade.FirstOrDefault(expression);
        }

        public Comunidade FindById(Guid id)
        {
            return _context.Comunidade.Find(id);
        }

        public IEnumerable<Comunidade> List()
        {
            return _context.Comunidade.ToList();
        }

        public IEnumerable<Comunidade> List(Func<Comunidade, bool> expression)
        {
            return _context.Comunidade.Where(expression);
        }

        public void Update(Comunidade entidade)
        {
            try
            {
                _context.Attach(entidade);
                _context.Entry(entidade).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }
    }
}