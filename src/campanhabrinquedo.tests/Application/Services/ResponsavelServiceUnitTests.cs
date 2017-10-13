using campanhabrinquedo.Application.Services;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using NSubstitute;

namespace campanhabrinquedo.tests.Application.Services
{
    public class ResponsavelServiceUnitTests : ServiceActionsUnitTests<Responsavel>
    {
        public ResponsavelServiceUnitTests()
        {
            Repository = Substitute.For<IResponsavelRepository>();
            Service = new ResponsavelService((IResponsavelRepository)Repository);
            Entity = new Responsavel("Marcelo", "11111111111");
            EntityInvalid = new Responsavel("", "");
        }
    }
}
