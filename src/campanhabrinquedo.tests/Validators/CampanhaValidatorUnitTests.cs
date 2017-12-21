namespace campanhabrinquedo.tests.Validators
{
    using Xunit;
    using domain.Entities;
    using domain.Validators;
    using FluentValidation.TestHelper;

    public class CampanhaValidatorUnitTests
    {   
        private readonly CampanhaValidator _validator;
        private readonly Campanha _campanha;

        public CampanhaValidatorUnitTests()
        {
             _validator = new CampanhaValidator();
            _campanha = new Campanha(2005, "");
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