using Galax.Solution.Domain.Commands.Validations.PaisValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.PaisCommands
{
    public class RemovePaisCommand : PaisCommand
    {
        public RemovePaisCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public override bool IsValid()
        {
            ValidationResult = new RemovePaisCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}
