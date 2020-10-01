using FluentValidation;
using Galax.Solution.Domain.Commands.CPFCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.CPFValidations
{
    public class CPFValidation<T> : AbstractValidator<T> where T : CPFCommand
    {
        protected void ValidateNumCPF() 
        {
            RuleFor(c => c.NumCPF)
                .NotEmpty().WithMessage("Por gentileza, informe o número do CPF.")
                .Length(11, 13).WithMessage("O número do CPF deve possuir entre 11 e 13 caracteres");

        }

        protected void ValidateId() 
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }
    }
}
