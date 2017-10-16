using System;
using System.Linq;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.Application.Services
{
    public class CriancaService : ServiceAction<Crianca>, ICriancaService
    {
        public CriancaService(ICriancaRepository repository)
            : base(repository) { }

        public override bool Existe(Crianca entity)
        {
            return Repository.FindByExpression(_ =>
                       _.Nome == entity.Nome
                       && _.Responsavel.Nome == entity.Responsavel.Nome
                       && _.Responsavel.RG == entity.Responsavel.RG
                    ) != null;
        }
    }
}