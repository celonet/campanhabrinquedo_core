namespace campanhabrinquedo.domain.Validacoes
{
    using campanhabrinquedo.domain.Entidades;
    using FluentValidation;
    using System;

    public class CampanhaValidacao : AbstractValidator<Campanha>
    {
        public void ValidaAno()
        {
            RuleFor(c => c.Ano)
                .GreaterThan(2005).WithMessage("Ano não pode ser menor que o primeiro ano da campanha ou maior que o ano vigente!")
                .LessThanOrEqualTo(DateTime.Now.AddYears(1).Year).WithMessage("Descrição não pode ser em branco!");
                
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Descrição não pode ser em branco!");

        }
    }
}