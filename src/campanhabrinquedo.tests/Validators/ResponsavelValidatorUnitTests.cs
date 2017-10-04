namespace campanhabrinquedo.tests.Validators
{
    using Xunit;
    using domain.Entities;
    using domain.Validators;
    using FluentValidation.TestHelper;

    public class ResponsavelValidatorUnitTests
    {
        private readonly ResponsavelValidator _validator;
        private readonly Responsavel _responsavel;

        public ResponsavelValidatorUnitTests()
        {
            _validator = new ResponsavelValidator();
            _responsavel = new Responsavel("","");
        }

        [Fact]
        public void DeveRetornarErro_QuandoNomeForInvalido()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Nome, _responsavel);
        }

        [Fact]
        public void DeveRetornarErro_QuandoRGForInvalido()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.RG, _responsavel);
        }
    }
}