namespace campanhabrinquedo.domain.Validators
{
    using campanhabrinquedo.domain.Entidades;
    using FluentValidation;
    using System;
    
    public class ResponsavelValidator : AbstractValidator<Responsavel>
    {
        public ResponsavelValidator()
        {
            RuleFor(responsavel => responsavel.Nome)
                .NotEmpty().WithMessage("Nome Obrigatório");
            RuleFor(responsavel => responsavel.RG)
                .NotEmpty().WithMessage("RG Obrigatório")
                .MinimumLength(8).WithMessage("RG não tem os tamanho valido");
        }
        
    }
}