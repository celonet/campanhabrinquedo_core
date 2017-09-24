using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios;
using campanhabrinquedo.domain.Repositorios.Base;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class CriancaRepositorio : ICriancaRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public CriancaRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        void Delete<Crianca>.Delete(Guid entidadeId)
        {
            throw new NotImplementedException();
        }

        Crianca Search<Crianca>.FindByExpression(Func<Crianca, bool> expression)
        {
            throw new NotImplementedException();
        }

        Crianca Search<Crianca>.FindById(Guid entidadeId)
        {
            throw new NotImplementedException();
        }

        void Insert<Crianca>.Insert(Crianca entidade)
        {
            _context.Crianca.Add(entidade);
            _context.SaveChanges();
        }

        IEnumerable<Crianca> Search<Crianca>.List()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Crianca> Search<Crianca>.List(Func<Crianca, bool> expression)
        {
            throw new NotImplementedException();
        }

        void Update<Crianca>.Update(Crianca entidade)
        {
            throw new NotImplementedException();
        }
    }
}