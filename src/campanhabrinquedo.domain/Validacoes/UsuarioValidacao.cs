namespace campanhabrinquedo.domain.Validacoes
{
    using campanhabrinquedo.domain.Entidades;
    using FluentValidation;
    using System;

    public class UsuarioValidacao : AbstractValidator<Usuario>
    {
        public void ValidaNome()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome é obrigatorio!")
                .MinimumLength(3).WithMessage("Minimo de 3 caracteres!");
        }

        public void ValidaEmail()
        {
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email é obrigatorio!")
                .EmailAddress().WithMessage("Email inválido!");
        }

        public void ValidaSenha()
        {
            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("Senha é obrigatoria")
                .MinimumLength(6).WithMessage("Minimo de 6 caracteres!");
        }
    }
}