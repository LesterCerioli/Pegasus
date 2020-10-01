using Galax.Solution.Domain.Commands.Validations.EntradaProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.EntradaProdutoCommands
{
    public class RemoveEntradaProdutoCommand : EntradaProdutoCommand 
    {
        public RemoveEntradaProdutoCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveEntradaProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
