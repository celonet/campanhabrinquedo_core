namespace  campanhabrinquedo.tests.Validators
{
    using Xunit;
    using campanhabrinquedo.domain.Entidades;
    using campanhabrinquedo.domain.Validators;
    using FluentValidation;
    using FluentValidation.TestHelper;    

    public class ComunidadeValidatorUnitTests
    {
        private ComunidadeValidator validator;

        public ComunidadeValidatorUnitTests()
        {
           validator = new ComunidadeValidator();
        }

        [Fact]
        public void DeveRetornarErro_QuandoNomeForVazia()
        {
            var comunidade = new Comunidade("","");
            validator.ShouldHaveValidationErrorFor(c => c.Nome, comunidade); 
        }

        [Fact]
        public void DeveRetornarErro_QuandoBairroForVazia()
        {
            var comunidade = new Comunidade("","");
            validator.ShouldHaveValidationErrorFor(c => c.Bairro, comunidade); 
        }
    }
}