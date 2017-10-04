namespace campanhabrinquedo.tests.Validators
{
    using Xunit;
    using domain.Entities;
    using domain.Validators;
    using FluentValidation.TestHelper;

    public class UsuarioValidatorUnitTests
    {
        private readonly UsuarioValidator _validator;
        private readonly Usuario _usuario;

        public UsuarioValidatorUnitTests()
        {
            _validator = new UsuarioValidator();
            _usuario = new Usuario("", "", "");
        }

        [Fact]
        public void DeveRetornarErro_QuandoNomeForInvalido()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Nome, _usuario);
        }

        [Fact]
        public void DeveRetornarErro_QuandoEmailForInvalido()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Email, _usuario);
        }

        [Fact]
        public void DeveRetornarErro_QuandoSenhaForInvalido()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Senha, _usuario);
        }
    }
}