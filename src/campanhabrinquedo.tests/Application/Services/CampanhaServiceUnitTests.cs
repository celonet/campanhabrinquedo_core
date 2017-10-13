using System;
using campanhabrinquedo.Application.Services;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using NSubstitute;

namespace campanhabrinquedo.tests.Application.Services
{
    public class CampanhaServiceUnitTests : ServiceActionsUnitTests<Campanha>
    {
        public CampanhaServiceUnitTests()
        {
            Repository = Substitute.For<ICampanhaRepository>();
            Service = new CampanhaService((ICampanhaRepository)Repository);
            Entity = new Campanha(DateTime.Now.Year, "Campanha Test");
            EntityInvalid = new Campanha(2005, "",0);
        }
    }
}
