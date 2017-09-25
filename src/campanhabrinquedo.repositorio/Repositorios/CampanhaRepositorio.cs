using System;
using System.Linq;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios;
using campanhabrinquedo.domain.Actions;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class CampanhaRepositorio : ICampanhaRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public CampanhaRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        IEnumerable<Campanha> domain.Actions.Search<Campanha>.List()
        {
            return _context.Campanha.ToList();
        }

        IEnumerable<Campanha> domain.Actions.Search<Campanha>.List(Func<Campanha, bool> expression)
        {
            return _context.Campanha.Where(expression);
        }

        Campanha domain.Actions.Search<Campanha>.FindById(Guid entidadeId)
        {
            return _context.Campanha.FirstOrDefault(campanha => campanha.CampanhaId == entidadeId);
        }

        Campanha domain.Actions.Search<Campanha>.FindByExpression(Func<Campanha, bool> expression)
        {
            return _context.Campanha.FirstOrDefault(expression);
        }

        public Campanha FindByExpression(Func<Campanha, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Campanha FindById(Guid entidadeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Campanha> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Campanha> List(Func<Campanha, bool> expression)
        {
            throw new NotImplementedException();
        }
    }
}