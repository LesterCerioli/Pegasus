using FluentValidation;
using Galax.Solution.Domain.Commands.InventarioEstoqueCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.InventarioEstoqueValidations
{
    public abstract class InventarioEstoqueValidation<T>  : AbstractValidator<T> where T : InventarioEstoqueCommand
    {
        protected void ValidateMotivo() 
        {
            RuleFor(h => h.Motivo)
                .NotEmpty().WithMessage("Por gentileza, informe o Motivo.")
                .Length(2, 100).WithMessage("O Motivo deve possuir entre 2 e 100 caracteres.");
        }

        protected void ValidateId() 
        {
            RuleFor(h => h.Id)
                .NotEqual(Guid.Empty);
        }
        
    }
}
