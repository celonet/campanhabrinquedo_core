using System;
using System.Linq;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;

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
            var comunidade = _context.Comunidade.FirstOrDefault(_ => _.Id == id);
            if (comunidade != null)
            {
                _context.Comunidade.Remove(comunidade);
                _context.SaveChanges();
            }
        }

        public Comunidade FindByExpression(Func<Comunidade, bool> expression)
        {
            return _context.Comunidade.Find(expression);
        }

        public Comunidade FindById(Guid id)
        {
            return _context.Comunidade.FirstOrDefault(Comunidade => Comunidade.Id == id);
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
            _context.Comunidade.Update(entidade);
            _context.SaveChanges();
        }
    }
}