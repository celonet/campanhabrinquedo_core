using System;
using campanhabrinquedo.domain.Entities;
using FluentAssertions;
using Xunit;

namespace campanhabrinquedo.tests.Domain
{
    public class UsuarioUnitTests
    {
        private readonly string _nome;
        private readonly string _email;
        private readonly string _senha;

        public UsuarioUnitTests()
        {
            _nome = "Fulano";
            _email = "fulano@detal.com";
            _senha = "123456";
        }

        [Fact]
        public void NovaInstanciaComId()
        {
            var id = Guid.NewGuid();

            var usuario = new Usuario(id, _nome, _email, _senha);

            usuario.Id.Should().Be(id);
            usuario.Nome.Should().Be(_nome);
            usuario.Email.Should().Be(_email);
            usuario.Senha.Should().Be(_senha);
        }

        [Fact]
        public void NovaInstanciaSemId()
        {
            var usuario = new Usuario(_nome, _email, _senha);

            usuario.Nome.Should().Be(_nome);
            usuario.Email.Should().Be(_email);
            usuario.Senha.Should().Be(_senha);
        }

        [Fact]
        public void IncluiDataCadastro()
        {
            var usuario = new Usuario(_nome, _email, _senha);
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