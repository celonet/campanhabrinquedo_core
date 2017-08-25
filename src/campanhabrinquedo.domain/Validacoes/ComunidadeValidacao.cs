namespace campanhabrinquedo.domain.Validacoes
{
    using System;
    using campanhabrinquedo.domain.Entidades;
    using FluentValidation;

     public class ComunidadeValidacao : ValidacaoBase<Comunidade>
     {
         public void ValidaBairro()
         {
             RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("Bairro não pode ser em branco!")
                .Length(3, 150).WithMessage("Bairro deve ter ao menos 3 caracteres!");
         }
     }
}