using System;
using System.Linq;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios;
using campanhabrinquedo.domain.Actions;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class ComunidadeRepositorio : IComunidadeRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public ComunidadeRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        void domain.Actions.Delete<Comunidade>.Delete(Guid entidadeId)
        {
            var comunidade = _context.Comunidade.FirstOrDefault(_ => _.ComunidadeId == entidadeId);
            if (comunidade != null)
            {
                _context.Comunidade.Remove(comunidade);
                _context.SaveChanges();
            }
        }

        Comunidade domain.Actions.Search<Comunidade>.FindByExpression(Func<Comunidade, bool> expression)
        {
            return _context.Comunidade.Find(expression);
        }

        Comunidade domain.Actions.Search<Comunidade>.FindById(Guid entidadeId)
        {
            return _context.Comunidade.FirstOrDefault(Comunidade => Comunidade.ComunidadeId == entidadeId);
        }

        void domain.Actions.Insert<Comunidade>.Insert(Comunidade entidade)
        {
            _context.Comunidade.Add(entidade);
            _context.SaveChanges();
        }

        IEnumerable<Comunidade> domain.Actions.Search<Comunidade>.List()
        {
            return _context.Comunidade;
        }

        IEnumerable<Comunidade> domain.Actions.Search<Comunidade>.List(Func<Comunidade, bool> expression)
        {
            return _context.Comunidade.Where(expression);
        }

        void domain.Actions.Update<Comunidade>.Update(Comunidade entidade)
        {
            _context.Comunidade.Update(entidade);
        }
    }
}