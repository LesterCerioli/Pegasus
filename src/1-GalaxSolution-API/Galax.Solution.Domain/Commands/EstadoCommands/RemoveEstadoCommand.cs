using Galax.Solution.Domain.Commands.Validations.EstadoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.EstadoCommands
{
    public class RemoveEstadoCommand : EstadoCommand
    {
        public RemoveEstadoCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveEstadoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
