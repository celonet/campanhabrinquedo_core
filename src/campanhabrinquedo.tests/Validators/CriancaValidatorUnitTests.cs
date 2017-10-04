namespace campanhabrinquedo.tests.Validators
{
    using Xunit;
    using domain.Entities;
    using domain.Validators;
    using FluentValidation.TestHelper;

    public class CriancaValidatorUnitTests
    {   
        private readonly CriancaValidator _validator;
        private readonly Crianca _crianca;

        public CriancaValidatorUnitTests()
        {
             _validator = new CriancaValidator();
             _crianca = new Crianca("", "", Sexo.Masculino, null, null, false,false);
        }    

        [Fact]
        public void DeveRetornarErro_QuandoNomeForInvalido()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Nome, _crianca); 
        }

        [Fact]
        public void DeveRetornarErro_QuandoIdadeForVazia()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Idade, _crianca); 
        }

        [Fact]
        public void DeveRetornarErro_QuandoComunidadeForVazia()
        {
            _validator.ShouldHaveChildValidator(x => x.Comunidade, typeof(ComunidadeValidator));
        }

        [Fact]
        public void DeveRetornarErro_QuandoResponsavelForVazia()
        {
            _validator.ShouldHaveChildValidator(x => x.Responsavel, typeof(ResponsavelValidator));
        }
     }
 }