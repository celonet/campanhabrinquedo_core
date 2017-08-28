namespace campanhabrinquedo.domain.Validacoes
{
    using campanhabrinquedo.domain.Entidades;
    using FluentValidation;
    using System;
    
    public class PadrinhoValidacao : AbstractValidator<Padrinho>
    {
        public PadrinhoValidacao()
        {
            RuleFor(padrinho => padrinho.Nome)
                .NotEmpty().WithMessage("Nome Obrigatório");
            RuleFor(padrinho => padrinho.Comunidade)
                .SetValidator(new ComunidadeValidacao());
            RuleFor(padrinho => padrinho.Telefone)
                .NotEmpty().WithMessage("Telefone é obrigatório");
        }
    }
}