using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class CriancaRepositorio : ICriancaRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public CriancaRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        void domain.Actions.Delete<Crianca>.Delete(Guid entidadeId)
        {
            throw new NotImplementedException();
        }

        Crianca domain.Actions.Search<Crianca>.FindByExpression(Func<Crianca, bool> expression)
        {
            throw new NotImplementedException();
        }

        Crianca domain.Actions.Search<Crianca>.FindById(Guid entidadeId)
        {
            throw new NotImplementedException();
        }

        void domain.Actions.Insert<Crianca>.Insert(Crianca entidade)
        {
            _context.Crianca.Add(entidade);
            _context.SaveChanges();
        }

        IEnumerable<Crianca> domain.Actions.Search<Crianca>.List()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Crianca> domain.Actions.Search<Crianca>.List(Func<Crianca, bool> expression)
        {
            throw new NotImplementedException();
        }

        void domain.Actions.Update<Crianca>.Update(Crianca entidade)
        {
            throw new NotImplementedException();
        }
    }
}