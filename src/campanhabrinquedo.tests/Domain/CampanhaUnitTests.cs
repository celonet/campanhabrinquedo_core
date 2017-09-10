using campanhabrinquedo.domain.Entidades;
using System;
using Xunit;
using FluentAssertions;

namespace campanhabrinquedo.tests
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