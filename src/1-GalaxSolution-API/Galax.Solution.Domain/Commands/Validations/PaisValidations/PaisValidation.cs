using FluentValidation;
using Galax.Solution.Domain.Commands.PaisCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.PaisValidation
{
    public abstract class PaisValidation<T> : AbstractValidator<T> where T : PaisCommand 
    {
        protected void ValidateNome() 
        {
            RuleFor(k => k.Nome)
                .NotEmpty().WithMessage("Por gentileza, informe o Nome do País.")
                .Length(2, 100).WithMessage("O Código deve possuir entre 2 e 100 caracteres.");
        }

        protected void ValidateCodigo()
        {
            RuleFor(k => k.Codigo)
                .NotEmpty().WithMessage("Por gentileza, informe o Código do País.")
                .Length(2, 100).WithMessage("O Código deve possuir entre 2 e 100 caracteres.");
        }

        protected void ValidateId()
        {
            RuleFor(k => k.Id)
                .NotEqual(Guid.Empty);
        }

    }

}
