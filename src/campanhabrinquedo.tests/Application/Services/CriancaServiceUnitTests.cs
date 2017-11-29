using campanhabrinquedo.Application.Services;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using NSubstitute;

namespace campanhabrinquedo.tests.Application.Services
{
    public class CriancaServiceUnitTests : ServiceActionsUnitTests<Crianca>
    {
        public CriancaServiceUnitTests()
        {
            Repository = Substitute.For<ICriancaRepository>();
            Service = new CriancaService((ICriancaRepository)Repository);
            Entity = new Crianca("Marcelo", "10", "8", "23", Sexo.Masculino, new Comunidade("Bairro Test", "Comunidade Test"), new Responsavel("Marcelo", "11111111111"));
            EntityInvalid = new Crianca("", "", "", "", Sexo.Masculino, new Comunidade("", ""), new Responsavel("", ""));
        }
    }
}
