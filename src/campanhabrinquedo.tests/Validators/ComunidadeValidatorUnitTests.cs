namespace campanhabrinquedo.tests.Validators
{
    using Xunit;
    using domain.Entities;
    using domain.Validators;
    using FluentValidation.TestHelper;

    public class ComunidadeValidatorUnitTests
    {
        private readonly ComunidadeValidator _validator;
        private readonly Comunidade _comunidade;

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