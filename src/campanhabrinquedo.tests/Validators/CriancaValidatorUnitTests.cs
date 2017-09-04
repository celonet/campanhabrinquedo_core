namespace campanhabrinquedo.tests.Validators
{
    using Xunit;
    using campanhabrinquedo.domain.Entidades;
    using campanhabrinquedo.domain.Validators;
    using FluentValidation;
    using FluentValidation.TestHelper;    

    public class CriancaValidatorUnitTests
    {   
        private CriancaValidator validator;
        private Crianca crianca;

        public CriancaValidatorUnitTests()
        {
             validator = new CriancaValidator();
             crianca = new Crianca("", "", Sexo.Masculino, null, null, false,false);
        }    

        [Fact]
        public void DeveRetornarErro_QuandoNomeForInvalido()
        {
            validator.ShouldHaveValidationErrorFor(c => c.Nome, crianca); 
        }

        [Fact]
        public void DeveRetornarErro_QuandoIdadeForVazia()
        {
            validator.ShouldHaveValidationErrorFor(c => c.Idade, crianca); 
        }

        [Fact]
        public void DeveRetornarErro_QuandoComunidadeForVazia()
        {
            validator.ShouldHaveChildValidator(x => x.Comunidade, typeof(ComunidadeValidator));
        }

        [Fact]
        public void DeveRetornarErro_QuandoResponsavelForVazia()
        {
            validator.ShouldHaveChildValidator(x => x.Responsavel, typeof(ResponsavelValidator));
        }
     }
 }