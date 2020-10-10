using Galax.Solution.Domain.Commands.Validations.EstadoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.StateCommands
{
    public class RemoveStateCommand : StateCommand
    {
        public RemoveStateCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveStateCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
