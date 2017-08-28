namespace campanhabrinquedo.tests
{       
    using campanhabrinquedo.domain.Entidades;
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
        // [Theory]
        // [InlineData(null)]
        // [InlineData("abc")]
        // [InlineData("")]
        // public void NomeEValido_QuandoPassadoUmNomeInvalido_DeveRetornarVerdadeiro(string nome)
        // {
        //     Exception ex = Assert.Throws<Exception>(() => new Usuario(nome, "", ""));    
        //     Assert.Equal("Nome é inválido", ex.Message);            
        // }

        // [Theory]
        // [InlineData(null)]
        // [InlineData("abc")]
        // [InlineData("")]
        // public void SenhaEValida_QuandoPassadoUmaSenhaInvalida_DeveRetornarFalso(string senha)
        // {
        //     Exception ex = Assert.Throws<Exception>(() => new Usuario("fulano", "fulano@detal.com", senha));    
        //     Assert.Equal("Senha inválida", ex.Message);
        // }

        // [Theory]
        // [InlineData(null)]
        // [InlineData("fulano.com")]
        // [InlineData("")]
        // public void EmailEValido_QuandoPassadoUmEmailInvalido_DeveRetornarFalso(string email)
        // {    
        //     Exception ex = Assert.Throws<Exception>(() => new Usuario("fulano", email, "123456"));    
        //     Assert.Equal("Email inválido", ex.Message);
        // }
    }
}