using System;
using System.Linq.Expressions;
using campanhabrinquedo.Application.Services;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace campanhabrinquedo.tests.Application.Services
{
    public class UsuarioServiceUnitTests : ServiceActionsUnitTests<Usuario>
    {
        public UsuarioServiceUnitTests()
        {
            Repository = Substitute.For<IUsuarioRepository>();
            Service = new UsuarioService((IUsuarioRepository)Repository);
            Entity = new Usuario("Marcelo", "marcelo.lopesdasilva@gmail.com", "123456");
            EntityInvalid = new Usuario("", "", "");
        }

        [Fact]
        public void Deve_Chamar_Metodo_Para_Verificar_Se_Existir_Objeto()
        {
            Repository.FindByExpression(Arg.Any<Func<Usuario, bool>>()).Returns(new Usuario("","",""));
            var existe = Service.Existe(Entity);
            Repository.Received().FindByExpression(Arg.Any<Func<Usuario, bool>>());
            existe.Should().BeTrue();
        }

        [Fact]
        public async void Deve_Chamar_Metodo_ParaLogarUsuario_Quando_Parametros_Validos()
        {
            await ((UsuarioService)Service).LogarUsuario("Marcelo", "123456");
            await Repository.Received().FindByExpressionAsync(Arg.Any<Expression<Func<Usuario, bool>>>());
        }

        [Fact]
        public async void Nao_Deve_Chamar_Metodo_ParaLogarUsuario_Quando_Parametros_Validos()
        {
            await ((UsuarioService)Service).LogarUsuario("", "");
            await Repository.DidNotReceive().FindByExpressionAsync(Arg.Any<Expression<Func<Usuario, bool>>>());
        }
    }
}
