using FluentValidation;
using Galax.Solution.Domain.Commands.EstadoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.EstadoValidations
{
    public abstract class EstadoValidation<T> : AbstractValidator<T> where T : EstadoCommand
    {
        protected void ValidateNome() 
        {
            RuleFor(e => e. Nome)
                .NotEmpty().WithMessage("Por gentileza, informe o nome do Estado.")
                .Length(2, 100).WithMessage("O nome deve possuir entre 2 e 100 caracteres.");

        }

        protected void ValidateUF()
        {
            RuleFor(e => e.UF)
                .NotEmpty().WithMessage("Por gentileza, informe o nome da Unidade Federativa.")
                .Length(2, 100).WithMessage("O nome deve possuir entre 2 e 100 caracteres.");

        }
        protected void ValidateId()
        {
            RuleFor(e => e.Id)
                .NotEqual(Guid.Empty);
        }

    }
}
