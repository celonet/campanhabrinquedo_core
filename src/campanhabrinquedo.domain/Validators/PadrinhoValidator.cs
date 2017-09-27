namespace campanhabrinquedo.domain.Validators
{
    using campanhabrinquedo.domain.Entities;
    using FluentValidation;

    public class PadrinhoValidator : AbstractValidator<Padrinho>
    {
        public PadrinhoValidator()
        {
            RuleFor(padrinho => padrinho.Nome)
                .NotEmpty().WithMessage("Nome Obrigatório");
            RuleFor(padrinho => padrinho.Comunidade)
                .SetValidator(new ComunidadeValidator());
            RuleFor(padrinho => padrinho.Telefone)
                .NotEmpty().WithMessage("Telefone é obrigatório");
        }
    }
}