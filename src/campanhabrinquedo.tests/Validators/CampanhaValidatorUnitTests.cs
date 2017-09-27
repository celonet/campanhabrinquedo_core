namespace campanhabrinquedo.tests.Validators
{
    using Xunit;
    using campanhabrinquedo.domain.Entities;
    using campanhabrinquedo.domain.Validators;
    using FluentValidation.TestHelper;

    public class CampanhaValidatorUnitTests
    {   
        private CampanhaValidator _validator;
        private Campanha _campanha;

        public CampanhaValidatorUnitTests()
        {
             _validator = new CampanhaValidator();
            _campanha = new Campanha(2005, "", 0);
        }    

         [Fact]
         public void DeveRetornarErro_QuandoAnoForInvalido()
         {
             _validator.ShouldHaveValidationErrorFor(c => c.Ano, _campanha); 
         }

         [Fact]
         public void DeveRetornarErro_QuandoDescricaoForVazia()
         {
             _validator.ShouldHaveValidationErrorFor(c => c.Descricao, _campanha); 
         }
     }
 }