using System;
using System.Linq;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class ResponsavelRepository : IResponsavelRepository
    {
        private CampanhaBrinquedoContext _context;

        public ResponsavelRepository(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        public void Create(Responsavel entidade)
        {
            _context.Responsavel.Add(entidade);
            _context.SaveChanges();
        }

        public void Update(Responsavel entidade)
        {
            _context.Responsavel.Update(entidade);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var responsavel = _context.Responsavel.Find(id);
            if (responsavel != null)
            {
                _context.Responsavel.Remove(responsavel);
                _context.SaveChanges();
            }
        }

        public Responsavel FindByExpression(Func<Responsavel, bool> expression)
        {
            return _context.Responsavel.FirstOrDefault(expression);
        }

        public Responsavel FindById(Guid id)
        {
            return _context.Responsavel.Find(id);
        }

        public IEnumerable<Responsavel> List()
        {
            return _context.Responsavel.ToList();
        }

        public IEnumerable<Responsavel> List(Func<Responsavel, bool> expression)
        {
            return _context.Responsavel.Where(expression);
        }
    }
}