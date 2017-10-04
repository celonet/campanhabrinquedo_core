namespace campanhabrinquedo.domain.Validators
{
    using Entities;
    using FluentValidation;
    using System;

    public class CampanhaValidator : AbstractValidator<Campanha>
    {
        public CampanhaValidator()
        {
            RuleFor(campanha => campanha.Ano)
                .GreaterThan(2005).WithMessage("Ano não pode ser menor que o primeiro ano da campanha ou maior que o ano vigente!")
                .LessThanOrEqualTo(DateTime.Now.AddYears(1).Year).WithMessage("Descrição não pode ser em branco!");
                
            RuleFor(campanha => campanha.Descricao)
                .NotEmpty().WithMessage("Descrição não pode ser em branco!");
        }
    }
}