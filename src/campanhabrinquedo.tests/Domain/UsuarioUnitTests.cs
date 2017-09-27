namespace campanhabrinquedo.tests
{       
    using campanhabrinquedo.domain.Entities;
    using FluentAssertions;
    using System;
    using Xunit;
    
    public class UsuarioUnitTests
    {
        Usuario usuario;

        public UsuarioUnitTests()
        {
            usuario = new Usuario("Fulano","fulano@detal.com","123456");
        }

        [Fact]
        public void IncluiDataCadastro()
        {
            usuario.IncluiDataCadastro();
            var dateAssert = DateTime.Now;
            usuario.DataCadastro.Should().HaveDay(dateAssert.Day);
            usuario.DataCadastro.Should().HaveMonth(dateAssert.Month);
            usuario.DataCadastro.Should().HaveYear(dateAssert.Year);
            usuario.DataCadastro.Should().HaveHour(dateAssert.Hour);
            usuario.DataCadastro.Should().HaveMinute(dateAssert.Minute);
        }
    }
}