namespace campanhabrinquedo.domain.Validacoes
{
    using campanhabrinquedo.domain.Entidades;
    using FluentValidation;
    using System;

    public class UsuarioValidacao : AbstractValidator<Usuario>
    {
        public UsuarioValidacao()
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