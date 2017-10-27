using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.Application.Services
{
    public class ComunidadeService : ServiceAction<Comunidade>, IComunidadeService
    {
        public ComunidadeService(IComunidadeRepository repository) 
            : base(repository) { }

        public override bool Existe(Comunidade comunidade)
        {
            return Repository.FindByExpression(_ => _.Nome == comunidade.Nome && _.Bairro == comunidade.Bairro) != null;
        }
    }
}