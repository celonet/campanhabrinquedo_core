using campanhabrinquedo.Application.Services;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using NSubstitute;

namespace campanhabrinquedo.tests.Application.Services
{
    public class ComunidadeServiceUnitTests : ServiceActionsUnitTests<Comunidade>
    {
        public ComunidadeServiceUnitTests()
        {
            Repository = Substitute.For<IComunidadeRepository>();
            Service = new ComunidadeService((IComunidadeRepository)Repository);
            Entity = new Comunidade("Test", "test");
            EntityInvalid = new Comunidade("", "");
        }
    }
}
