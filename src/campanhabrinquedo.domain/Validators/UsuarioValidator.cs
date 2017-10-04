namespace campanhabrinquedo.domain.Validators
{
    using Entities;
    using FluentValidation;

    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(usuario => usuario.Nome)
                .NotEmpty().WithMessage("Nome é obrigatorio!")
                .MinimumLength(3).WithMessage("Minimo de 3 caracteres!");
            RuleFor(usuario => usuario.Email)
                .NotEmpty().WithMessage("Email é obrigatorio!")
                .EmailAddress().WithMessage("Email inválido!");
            RuleFor(usuario => usuario.Senha)
                .NotEmpty().WithMessage("Senha é obrigatoria")
                .MinimumLength(6).WithMessage("Minimo de 6 caracteres!");
        }
    }
}