using System;
using Galax.Solution.Domain.Commands.Validations.CidadeValidations;

namespace Galax.Solution.Domain.Commands.CidadeCommands
{
    public class RemoveCidadeCommand : CidadeCommand
    {
        public RemoveCidadeCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }    

        public override bool IsValid()
        {
            ValidationResult = new RemoveCidadeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
        
        
    }
}