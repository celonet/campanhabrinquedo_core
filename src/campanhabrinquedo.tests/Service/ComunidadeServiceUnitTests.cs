using System;
using System.Collections.Generic;
using System.Linq;
using campanhabrinquedo.Application.Services;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace campanhabrinquedo.tests.Service
{
    public class ComunidadeServiceUnitTests
    {
        private readonly ComunidadeService _comunidadeService;

        public ComunidadeServiceUnitTests()
        {
            var comunidades = new List<Comunidade>
            {
                new Comunidade("Comunidade 1", "Bairro 1"),
                new Comunidade("Comunidade 2", "Bairro 2")
            };

            var comunidadeRepository = Substitute.For<IComunidadeRepository>();
            comunidadeRepository
                .List()
                .Returns(comunidades.AsQueryable());
            comunidadeRepository
                .FindById(Arg.Any<Guid>())
                .Returns(_ => comunidades.First(a => a.Id == (Guid)_[0]));
            comunidadeRepository
                .When(_ => _.Create(Arg.Any<Comunidade>()))
                .Do(_ => comunidades.Add(_.Arg<Comunidade>()));
            comunidadeRepository
                .When(_ => _.Delete(Arg.Any<Guid>()))
                .Do(id => comunidades.Remove(comunidades.FirstOrDefault(a => a.Id == id.Arg<Guid>())));

            _comunidadeService = new ComunidadeService(comunidadeRepository);
        }

        [Fact]
        public void Deve_Listar_Comunidades()
        {
            var comunidades = _comunidadeService.ListaComunidades();
            comunidades.Should().HaveCount(2);
        }

        [Fact]
        public void Deve_Retornar_Comunidade_Por_Id()
        {
            var comunidades = _comunidadeService.ListaComunidades().ToList();
            var comunidade = _comunidadeService.RetornaComunidadePorId(comunidades[0].Id);
            comunidade.ShouldBeEquivalentTo(comunidades[0]);
        }

        [Fact]
        public void Deve_InserirNovaComunidade()
        {
            var comunidade = new Comunidade("Test", "test");
            _comunidadeService.InsereComunidade(comunidade);
            var comunidades = _comunidadeService.ListaComunidades();
            comunidades.Should().HaveCount(3);
        }

        [Fact]
        public void Deve_AlterarComunidade()
        {
            var comunidades = _comunidadeService.ListaComunidades().ToList();
            var comunidade = new Comunidade(comunidades[0].Id, "Test Nome 2","Test Bairro 2");
            _comunidadeService.AlteraComunidade(comunidade);

            var comunidadeAlterada = _comunidadeService.RetornaComunidadePorId(comunidade.Id);
            comunidadeAlterada.Bairro.Should().Be(comunidade.Bairro);
            comunidadeAlterada.Nome.Should().Be(comunidade.Nome);
        }

        [Fact]
        public void Deve_DeletarComunidade()
        {
            var comunidades = _comunidadeService.ListaComunidades().ToList();
            _comunidadeService.DeletaComunidade(comunidades[0].Id);
            comunidades.Should().HaveCount(2);
        }
    }
}
