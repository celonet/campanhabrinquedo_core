using campanhabrinquedo.Application.Services;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using NSubstitute;

namespace campanhabrinquedo.tests.Application.Services
{
    public class PadrinhoServiceUnitTests : ServiceActionsUnitTests<Padrinho>
    {
        public PadrinhoServiceUnitTests()
        {
            Repository = Substitute.For<IPadrinhoRepository>();
            Service = new PadrinhoService((IPadrinhoRepository)Repository);
            Entity = new Padrinho("Marcelo", new Comunidade("Bairro Teste", "Comunidade Teste"), "11112222", "");
            EntityInvalid = new Padrinho("", new Comunidade("", ""), "", "");
        }
    }
}
