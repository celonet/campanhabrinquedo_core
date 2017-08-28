namespace campanhabrinquedo.tests.Validacoes
{
    using Xunit;
    using campanhabrinquedo.domain.Entidades;
    using campanhabrinquedo.domain.Validacoes;
    using FluentValidation;
    using FluentValidation.TestHelper;    

    public class CampanhaValidatorUnitTests
    {   
        private CampanhaValidator validator;

        public CampanhaValidatorUnitTests()
        {
             validator = new CampanhaValidator();
        }    

         [Fact]
         public void Should_have_error_when_Name_is_null()
         {
             var campanha = new Campanha(0,"", 0);
             validator.ShouldHaveValidationErrorFor(c => c.Descricao, campanha); 
         }
     }
 }