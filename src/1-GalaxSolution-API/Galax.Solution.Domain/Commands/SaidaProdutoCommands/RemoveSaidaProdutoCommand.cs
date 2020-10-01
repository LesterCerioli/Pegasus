using Galax.Solution.Domain.Commands.Validations.SaidaProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.SaidaProdutoCommands
{
    public class RemoveSaidaProdutoCommand : SaidaProdutoCommand
    {
        public RemoveSaidaProdutoCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveSaidaProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
