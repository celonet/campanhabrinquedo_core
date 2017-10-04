namespace campanhabrinquedo.domain.Validators
{
    using Entities;
    using FluentValidation;

    public class ComunidadeValidator : AbstractValidator<Comunidade>
    {
        public ComunidadeValidator()
        {
            RuleFor(comunidade => comunidade.Nome)
                .NotEmpty().WithMessage("Nome não pode ser em branco!")
                .Length(3, 150).WithMessage("Nome deve ter ao menos 3 caracteres!");
            RuleFor(comunidade => comunidade.Bairro)
               .NotEmpty().WithMessage("Bairro não pode ser em branco!")
               .Length(3, 150).WithMessage("Bairro deve ter ao menos 3 caracteres!");
        }
    }
}