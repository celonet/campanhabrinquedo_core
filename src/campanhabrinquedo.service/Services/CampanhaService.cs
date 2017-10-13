using System;
using System.Linq;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.Application.Services
{
    public class CampanhaService : ServiceAction<Campanha>, ICampanhaService
    {
        public CampanhaService(ICampanhaRepository repository)
            : base(repository) { }

        public override bool Existe(Campanha entity)
        {
            return Repository.FindByExpression(_ => _.Ano == entity.Ano) != null;
        }
    }
}