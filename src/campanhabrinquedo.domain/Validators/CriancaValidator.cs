namespace campanhabrinquedo.domain.Validators
{
    using campanhabrinquedo.domain.Entities;
    using FluentValidation;

    public class CriancaValidator : AbstractValidator<Crianca>
    {
        public CriancaValidator()
        {
            RuleFor(crianca => crianca.Nome)
                .NotEmpty().WithMessage("Nome obrigatório!");
            RuleFor(crianca => crianca.Idade)
                .NotEmpty().WithMessage("Idade Obrigatória!");
            RuleFor(crianca => crianca.Comunidade)
                .SetValidator(new ComunidadeValidator());
            RuleFor(crianca => crianca.Responsavel)
                .SetValidator(new ResponsavelValidator());
        }
    }
}