using System;
using System.Linq;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios;
using campanhabrinquedo.domain.Repositorios.Base;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class CampanhaRepositorio : ICampanhaRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public CampanhaRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        Campanha Search<Campanha>.FindByExpression(Func<Campanha, bool> expression)
        {
            return _context.Campanha.Find(expression);
        }

        Campanha Search<Campanha>.FindById(Guid entidadeId)
        {
            return _context.Campanha.FirstOrDefault(campanha => campanha.CampanhaId == entidadeId);
        }

        IEnumerable<Campanha> Search<Campanha>.List()
        {
            return _context.Campanha.ToList();
        }

        IEnumerable<Campanha> Search<Campanha>.List(Func<Campanha, bool> expression)
        {
            return _context.Campanha.Where(expression);
        }
    }
}