using campanhabrinquedo.domain.Entidades;
using System;
using Xunit;

namespace campanhabrinquedo.tests
{
    public class CampanhaUnitTests
    {
        [Fact]
        public void CriarNovaCampanha_CasoDescricaoEstejaEmBranco_RetornarErro()
        {
            var ano = 2017;
            var descricao = "";
            var qdteCrianca = 0;
            
            Exception ex = Assert.Throws<Exception>(() => new Campanha(ano, descricao, qdteCrianca));        
            Assert.Equal("Descrição não pode ser em branco!", ex.Message);            
        }

        [Fact]
        public void CriarNovaCampanha_CasoAnoSejaMenorQueAnoBase_RetornarErro()
        {
            var ano = 2001;
            var descricao = "";
            var qdteCrianca = 0;
            
            Exception ex = Assert.Throws<Exception>(() => new Campanha(ano, descricao, qdteCrianca));        
            Assert.Equal("Ano não pode ser menor que o primeiro ano da campanha ou maior que o ano vigente!", ex.Message);            
        }

        [Fact]
        public void CriarNovaCampanha_CasoAnoSejaMaiorQueAnoVigente_RetornarErro()
        {
            var ano =  DateTime.Now.AddYears(1).Year;
            var descricao = "";
            var qdteCrianca = 0;
            
            Exception ex = Assert.Throws<Exception>(() => new Campanha(ano, descricao, qdteCrianca));        
            Assert.Equal("Ano não pode ser menor que o primeiro ano da campanha ou maior que o ano vigente!", ex.Message);            
        }

        [Fact]
        public void IncrementaQuantidadeCriancas()
        {
            var campanha = new Campanha(DateTime.Now.Year, "Teste", 0);
            campanha.IncrementaQuantidadeCriancas();
            Assert.Equal(1,campanha.QtdeCriancas);

        }
    }
}