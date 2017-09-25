using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class PadrinhoRepositorio : IPadrinhoRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public PadrinhoRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        public void Delete(Guid entidadeId)
        {
            throw new NotImplementedException();
        }

        public Padrinho FindByExpression(Func<Padrinho, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Padrinho FindById(Guid entidadeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Padrinho> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Padrinho> List(Func<Padrinho, bool> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Padrinho entidade)
        {
            throw new NotImplementedException();
        }

        void domain.Actions.Insert<Padrinho>.Insert(Padrinho entidade)
        {
            _context.Padrinho.Add(entidade);
            _context.SaveChanges();
        }
    }
}