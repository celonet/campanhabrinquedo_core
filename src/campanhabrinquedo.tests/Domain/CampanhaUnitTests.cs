using System;
using campanhabrinquedo.domain.Entities;
using FluentAssertions;
using Xunit;

namespace campanhabrinquedo.tests.Domain
{
    public class CampanhaUnitTests
    {
        [Fact]
        public void IncrementaQuantidadeCriancas()
        {
            var campanha = new Campanha(DateTime.Now.Year, "Teste", 0);
            campanha.IncrementaQuantidadeCriancas();
            campanha.QtdeCriancas.Should().Be(1);
        }
    }
}