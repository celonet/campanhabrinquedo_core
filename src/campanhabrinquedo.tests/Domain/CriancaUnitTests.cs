using campanhabrinquedo.domain.Entities;
using FluentAssertions;
using Xunit;

namespace campanhabrinquedo.tests.Domain
{
    public class CriancaUnitTests
    {
        private readonly Crianca _crianca;

        public CriancaUnitTests()
        {
            var comunidade = new Comunidade("nome", "bairro");
            var responsavel = new Responsavel("nome", "123456");
            _crianca = new Crianca("crianca","2 meses", Sexo.Feminino, comunidade, responsavel, false, false);
        }

        [Fact]
        public void Imprimir_DeveSetarImpressoNoCadastro()
        {
            _crianca.Imprimir();
            _crianca.Impresso.Should().BeTrue();
        }

        [Fact]
        public void EhEspecial_DeveSetarEspecialNoCadastro()
        {            
            _crianca.EhEspecial();
            _crianca.Especial.Should().BeTrue();
        }
    }
}