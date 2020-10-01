using Galax.Solution.Domain.Commands.Validations.PerfilValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.PerfilCommands
{
    public class RemovePerfilCommand : PerfilCommand
    {
        public RemovePerfilCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public override bool IsValid()
        {
            ValidationResult = new RemovePerfilCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
