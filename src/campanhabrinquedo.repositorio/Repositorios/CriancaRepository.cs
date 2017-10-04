using System;
using System.Linq;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class CriancaRepository : ICriancaRepository
    {
        private CampanhaBrinquedoContext _context;

        public CriancaRepository(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        public void Create(Crianca entitie)
        {
            _context.Crianca.Add(entitie);
            _context.SaveChanges();
        }

        public void Update(Crianca entidade)
        {
            _context.Crianca.Update(entidade);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var crianca = _context.Crianca.Find(id);
            if (crianca != null)
            {
                _context.Crianca.Remove(crianca);
                _context.SaveChanges();
            }
        }

        public Crianca FindByExpression(Func<Crianca, bool> expression)
        {
            return _context.Crianca.FirstOrDefault(expression);
        }

        public Crianca FindById(Guid entidadeId)
        {
            return _context.Crianca.Find(entidadeId);
        }

        public IEnumerable<Crianca> List()
        {
            return _context.Crianca.ToList();
        }

        public IEnumerable<Crianca> List(Func<Crianca, bool> expression)
        {
            return _context.Crianca.Where(expression);
        }
    }
}