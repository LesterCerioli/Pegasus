using System;
using Galax.Solution.Domain.Commands.Validations.CidadeValidations;
using Galax.Solution.Domain.Commands.Validations.CNPJValidations;

namespace Galax.Solution.Domain.Commands.CNPJCommands
{
    public class RemoveCNPJCommand : CNPJCommand
    {
        public RemoveCNPJCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveCNPJCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}