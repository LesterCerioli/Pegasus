using Galax.Solution.Domain.Commands.Validations.CPFValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.CPFCommands
{
    public class RemoveCPFCommand : CPFCommand
    {
        public RemoveCPFCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveCPFCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
