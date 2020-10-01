using Galax.Solution.Domain.Commands.Validations.UnidadeMedidaValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.UnidadeMedidaCommands
{
    public class RemoveUnidadeMedidaCommand : UnidadeMedidaCommand
    {
        public RemoveUnidadeMedidaCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveUnidadeMedidaCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
