using System;
using System.Linq;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Actions;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class PadrinhoRepository : IPadrinhoRepository
    {
        private CampanhaBrinquedoContext _context;

        public PadrinhoRepository(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        public void Delete(Guid id)
        {
            var padrinho = _context.Padrinho.FirstOrDefault(_ => _.Id == id);
            if (padrinho != null)
            {
                _context.Remove(padrinho);
                _context.SaveChanges();
            }
        }

        public Padrinho FindByExpression(Func<Padrinho, bool> expression)
        {
            return _context.Padrinho.FirstOrDefault(expression);
        }

        public Padrinho FindById(Guid id)
        {
            return _context.Padrinho.FirstOrDefault(_ => _.Id == id);
        }

        public IEnumerable<Padrinho> List()
        {
            return _context.Padrinho.ToList();
        }

        public IEnumerable<Padrinho> List(Func<Padrinho, bool> expression)
        {
            return _context.Padrinho.Where(expression);
        }

        public void Update(Padrinho entidade)
        {
            _context.Padrinho.Update(entidade);
            _context.SaveChanges();
        }

        void Create(Padrinho entitie)
        {
            _context.Padrinho.Add(entitie);
            _context.SaveChanges();
        }

        void ICreate<Padrinho>.Create(Padrinho entitie)
        {
            throw new NotImplementedException();
        }
    }
}