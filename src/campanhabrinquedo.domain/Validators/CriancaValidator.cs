namespace campanhabrinquedo.domain.Validators
{
    using Entities;
    using FluentValidation;

    public class CriancaValidator : AbstractValidator<Crianca>
    {
        public CriancaValidator()
        {
            RuleFor(crianca => crianca.Nome)
                .NotEmpty().WithMessage("Nome obrigatório!");
            RuleFor(crianca => crianca.Idade)
                .NotEmpty().WithMessage("Idade Obrigatória!");
            RuleFor(crianca => crianca.Roupa)
                .NotEmpty().WithMessage("Tamanho de roupa obrigatório!");
            RuleFor(crianca => crianca.Comunidade)
                .NotNull()
                .SetValidator(new ComunidadeValidator());
            RuleFor(crianca => crianca.Responsavel)
                .NotNull()
                .SetValidator(new ResponsavelValidator());
        }
    }
}