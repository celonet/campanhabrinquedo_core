namespace campanhabrinquedo.domain.Validacoes
{
    using System;
    using campanhabrinquedo.domain.Entidades;
    using FluentValidation;

    public class ComunidadeValidacao : AbstractValidator<Comunidade>
    {
        protected void ValidaNome()
        {
            RuleFor(c => c.Nome)
            .NotEmpty().WithMessage("Nome não pode ser em branco!")
            .Length(3, 150).WithMessage("Nome deve ter ao menos 3 caracteres!");
        }

        public void ValidaBairro()
        {
            RuleFor(c => c.Bairro)
               .NotEmpty().WithMessage("Bairro não pode ser em branco!")
               .Length(3, 150).WithMessage("Bairro deve ter ao menos 3 caracteres!");
        }
    }
}