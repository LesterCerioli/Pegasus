using FluentValidation;
using Galax.Solution.Domain.Commands.CNPJCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.CNPJValidations
{
    public abstract class CNPJValidation<T> : AbstractValidator<T> where T : CNPJCommand 
    {
        protected void ValidateNumCNPJ() 
        {
            RuleFor(b => b.NumCNPJ)
                .NotEmpty().WithMessage("Por gentilea, informe o número do CNPJ")
                .Length(11, 15).WithMessage("O número do CNPJ deve possuir entre 11 e 15 caracteres");
        }

        protected void ValidateId() 
        {
            RuleFor(b => b.Id)
                .NotEqual(Guid.Empty);
        }
    }

          
}
