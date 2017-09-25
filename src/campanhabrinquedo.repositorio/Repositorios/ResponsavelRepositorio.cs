using System;
using System.Linq;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class ResponsavelRepositorio : IResponsavelRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public ResponsavelRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        void domain.Actions.Delete<Responsavel>.Delete(Guid entidadeId)
        {
            var responsavel = _context.Responsavel.FirstOrDefault(_ => _.ResponsavelId == entidadeId);
            if (responsavel != null)
            {
                _context.Responsavel.Remove(responsavel);
                _context.SaveChanges();
            }
        }

        Responsavel domain.Actions.Search<Responsavel>.FindByExpression(Func<Responsavel, bool> expression)
        {
            return _context.Responsavel.Find(expression);
        }

        Responsavel domain.Actions.Search<Responsavel>.FindById(Guid entidadeId)
        {
            return _context.Responsavel.FirstOrDefault(_ => _.ResponsavelId == entidadeId);
        }

        void domain.Actions.Insert<Responsavel>.Insert(Responsavel entidade)
        {
            _context.Responsavel.Add(entidade);
            _context.SaveChanges();
        }

        IEnumerable<Responsavel> domain.Actions.Search<Responsavel>.List()
        {
            return _context.Responsavel;
        }

        IEnumerable<Responsavel> domain.Actions.Search<Responsavel>.List(Func<Responsavel, bool> expression)
        {
            return _context.Responsavel.Where(expression);
        }

        void domain.Actions.Update<Responsavel>.Update(Responsavel entidade)
        {
            _context.Responsavel.Update(entidade);
        }
    }
}