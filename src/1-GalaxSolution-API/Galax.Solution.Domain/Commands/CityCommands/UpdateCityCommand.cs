using FluentValidation;
using Galax.Solution.Domain.Commands.Validations.CityValidations;
using System;

namespace Galax.Solution.Domain.Commands.CityCommands
{
    public class UpdateCityCommand : CityCommand
    {
        public UpdateCityCommand(Guid id, string name, bool actived)
        {
            Id = id;
            Name = name;
            Actived = actived;
        }
            

        
        
            
        

        public override bool IsValid()
        {
            ValidationResult = new UpdateCityCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
        
    }
}