namespace campanhabrinquedo.tests.Validators
{
    using Xunit;
    using domain.Entities;
    using domain.Validators;
    using FluentValidation.TestHelper;

    public class PadrinhoValidatorUnitTests
    {
        private readonly PadrinhoValidator _validator;
        private readonly Padrinho _padrinho;

        public PadrinhoValidatorUnitTests()
        {
            _validator = new PadrinhoValidator();
            _padrinho = new Padrinho("", null, "", "");
        }

        [Fact]
        public void DeveRetornarErro_QuandoNomeForInvalido()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Nome, _padrinho);
        }

        [Fact]
        public void DeveRetornarErro_QuandoTelefoneForEmBranco()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Telefone, _padrinho);
        }

        [Fact]
        public void DeveRetornarErro_QuandoComunidadeForVazia()
        {
            _validator.ShouldHaveChildValidator(x => x.Comunidade, typeof(ComunidadeValidator));
        }

    }
}