using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.Application.Services
{
    public class PadrinhoService : ServiceAction<Padrinho>, IPadrinhoService
    {
        private IComunidadeService _comunidadeService;
        public PadrinhoService(IPadrinhoRepository repository, IComunidadeService comunidadeService)
            : base(repository) {
            _comunidadeService = comunidadeService;
        }

        public override bool Existe(Padrinho entity)
        {
            return Repository.FindByExpression(_ =>
                _.Nome == entity.Nome &&
                _.Comunidade == entity.Comunidade
            ) != null;
        }
    }
}