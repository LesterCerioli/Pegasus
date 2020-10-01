using FluentValidation;
using Galax.Solution.Domain.Commands.EntradaProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.EntradaProdutoValidations
{
    public abstract class EntradaProdutoValidation<T> : AbstractValidator<T> where T : EntradaProdutoCommand 
    {
        protected void ValidateNumero() 
        {
            RuleFor(d => d.Numero)
                .NotEmpty().WithMessage("Por gentileza, informe o número da entrada do produto.")
                .Length(1, 100).WithMessage("O número da entrada do produto deve possuir entre 1 e 100 caracteres.");
        
        }

        protected void ValidateId() 
        {
            RuleFor(d => d.Id)
                .NotEqual(Guid.Empty);
        }

    }
}
