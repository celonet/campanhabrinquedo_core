using System;
using System.Linq;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.Application.Services
{
    public class PadrinhoService : ServiceAction<Padrinho>, IPadrinhoService
    {
        public PadrinhoService(IPadrinhoRepository repository)
            : base(repository) { }

        public override bool Existe(Padrinho entity)
        {
            return Repository.FindByExpression(_ =>
                _.Nome == entity.Nome &&
                _.Comunidade == entity.Comunidade
            ) != null;
        }
    }
}