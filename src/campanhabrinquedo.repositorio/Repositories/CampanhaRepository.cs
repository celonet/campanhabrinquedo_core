using System;
using System.Collections.Generic;
using System.Linq;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;

namespace campanhabrinquedo.repository.Repositories
{
    public class CampanhaRepository : ICampanhaRepository
    {
        private readonly CampanhaBrinquedoContext _context;

        public CampanhaRepository(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        public void Create(Campanha entidade)
        {
            _context.Campanha.Add(entidade);
            _context.SaveChanges();
        }

        public void Update(Campanha entidade)
        {
            _context.Campanha.Update(entidade);
            _context.SaveChanges();
        }

        public void Delete(Guid entidadeId)
        {
            var campanha = _context.Campanha.Find(entidadeId);
            if (campanha != null)
            {
                _context.Campanha.Remove(campanha);
                _context.SaveChanges();
            }
        }

        public Campanha FindByExpression(Func<Campanha, bool> expression)
        {
            return _context.Campanha.FirstOrDefault(expression);
        }

        public Campanha FindById(Guid entidadeId)
        {
            return _context.Campanha.Find(entidadeId);
        }

        public IEnumerable<Campanha> List()
        {
            return _context.Campanha.ToList();
        }

        public IEnumerable<Campanha> List(Func<Campanha, bool> expression)
        {
            return _context.Campanha.Where(expression);
        }
    }
}