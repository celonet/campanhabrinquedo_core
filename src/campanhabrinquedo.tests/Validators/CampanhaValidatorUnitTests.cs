namespace campanhabrinquedo.tests.Validators
{
    using Xunit;
    using campanhabrinquedo.domain.Entidades;
    using campanhabrinquedo.domain.Validators;
    using FluentValidation.TestHelper;

    public class CampanhaValidatorUnitTests
    {   
        private CampanhaValidator validator;

        public CampanhaValidatorUnitTests()
        {
             validator = new CampanhaValidator();
        }    

         [Fact]
         public void DeveRetornarErro_QuandoAnoForInvalido()
         {
             var campanha = new Campanha(2005,"", 0);
             validator.ShouldHaveValidationErrorFor(c => c.Ano, campanha); 
         }

         [Fact]
         public void DeveRetornarErro_QuandoDescricaoForVazia()
         {
             var campanha = new Campanha(0,"", 0);
             validator.ShouldHaveValidationErrorFor(c => c.Descricao, campanha); 
         }
     }
 }