using FluentValidation;
using Galax.Solution.Domain.Commands.LocalArmazenamentoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.LocalArmazenamentoValidations
{
    public abstract class LocalArmazenamentoValidation<T> : AbstractValidator<T> where T : LocalArmazenamentoCommand
    {
        protected void ValidateNome() 
        {
            RuleFor(i => i.Nome)
                .NotEmpty().WithMessage("POr gentileza, informe o Nome do Local de Armazenamento.")
                .Length(2, 100).WithMessage("O Nome do Local de Armazenamento deve possuir entre 2 e 100 caracteres.");

        }

        protected void ValidateId() 
        {
            RuleFor(i => i.Id)
                .NotEqual(Guid.Empty);

        }

    }
}
