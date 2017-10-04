using System.Collections.Generic;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.service.Services;
using FluentAssertions;
using Xunit;

namespace campanhabrinquedo.tests.Service
{
    public class ComunidadeServiceUnitTests
    {
        private readonly ComunidadeService _comunidadeService;
        //private IMock<IComunidadeRepository> _comunidadeRepository;

        public ComunidadeServiceUnitTests()
        {
            var comunidades = new List<Comunidade>
            {
                new Comunidade("Comunidade 1", "Bairro 1"),
                new Comunidade("Comunidade 2", "Bairro 2")
            };

            //_comunidadeRepository = new Mock<IComunidadeRepository>();
            //var comunidadeRepository = Substitute.For<IComunidadeRepository>();
            //comunidadeRepository.List().Returns(comunidades);

            //comunidadeRepository.FindById(comunidades[0].Id).Returns(comunidades[0]);


            //_comunidadeService = new ComunidadeService(comunidadeRepository);
        }

        //[Fact]
        public void Deve_Listar_Comunidades()
        {
            var comunidades = _comunidadeService.ListaComunidades();
            comunidades.Should().HaveCount(2);
        }

        //[Fact]
        public void Deve_Retornar_Comunidade_Por_Id()
        {
            var comunidades = _comunidadeService.ListaComunidades();

            var comunidade = _comunidadeService.RetornaComunidadePorId(comunidades[0].Id);

            comunidade.ShouldBeEquivalentTo(comunidades[0]);
        }
    }
}
