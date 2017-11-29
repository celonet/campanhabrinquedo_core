using campanhabrinquedo.Application.Services;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;
using NSubstitute;

namespace campanhabrinquedo.tests.Application.Services
{
    public class PadrinhoServiceUnitTests : ServiceActionsUnitTests<Padrinho>
    {
        public PadrinhoServiceUnitTests()
        {
            Repository = Substitute.For<IPadrinhoRepository>();
            var comunidadeService = Substitute.For<IComunidadeService>();
            Service = new PadrinhoService((IPadrinhoRepository)Repository, comunidadeService);
            Entity = new Padrinho("Marcelo", new Comunidade("Bairro Teste", "Comunidade Teste"), "11112222", "");
            EntityInvalid = new Padrinho("", new Comunidade("", ""), "", "");
        }
    }
}
