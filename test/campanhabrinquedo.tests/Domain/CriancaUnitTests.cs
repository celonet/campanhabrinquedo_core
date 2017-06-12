using System;
using campanhabrinquedo.domain.Entities;
using Xunit;

namespace campanhabrinquedo.tests
{
    public class CriancaUnitTests
    {
        [Fact]
        public void Imprimir_DeveSetarImpressoNoCadastro()
        {
            var crianca = new Crianca();

            crianca.Imprimir();

            Assert.Equal(true, crianca.Impresso);
        }

        [Fact]
        public void EhEspecial_DeveSetarEspecialNoCadastro()
        {
            var crianca = new Crianca();

            crianca.EhEspecial();

            Assert.Equal(true, crianca.Especial);
        }
    }
}