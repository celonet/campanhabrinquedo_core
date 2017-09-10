namespace campanhabrinquedo.tests.Validators
{
    using Xunit;
    using campanhabrinquedo.domain.Entidades;
    using campanhabrinquedo.domain.Validators;
    using FluentValidation.TestHelper;

    public class ComunidadeValidatorUnitTests
    {
        private ComunidadeValidator _validator;
        private Comunidade _comunidade;

        public ComunidadeValidatorUnitTests()
        {
           _validator = new ComunidadeValidator();
            _comunidade = new Comunidade("", "");
        }

        [Fact]
        public void DeveRetornarErro_QuandoNomeForVazia()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Nome, _comunidade); 
        }

        [Fact]
        public void DeveRetornarErro_QuandoBairroForVazia()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Bairro, _comunidade); 
        }
    }
}