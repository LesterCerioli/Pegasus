using Galax.Solution.Domain.Commands.Validations.CityValidations;
using System;


namespace Galax.Solution.Domain.Commands.CityCommands
{
    public class RemoveCityCommand : CityCommand
    {
        public RemoveCityCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }    

        public override bool IsValid()
        {
            ValidationResult = new RemoveCityCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
        
        
    }
}