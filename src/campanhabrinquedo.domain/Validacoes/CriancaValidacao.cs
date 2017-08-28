namespace campanhabrinquedo.domain.Validacoes
{
    using campanhabrinquedo.domain.Entidades;
    using FluentValidation;
    using System;
    
    public class CriancaValidacao : AbstractValidator<Crianca>
    {
        public CriancaValidacao()
        {
            RuleFor(crianca => crianca.Nome)
                .NotEmpty().WithMessage("Nome obrigatório!");
            RuleFor(crianca => crianca.Idade)
                .NotEmpty().WithMessage("Idade Obrigatória!");
            RuleFor(crianca => crianca.Comunidade)
                .SetValidator(new ComunidadeValidacao());
            RuleFor(crianca => crianca.Responsavel)
                .SetValidator(new ResponsavelValidacao());
        }
    }
}