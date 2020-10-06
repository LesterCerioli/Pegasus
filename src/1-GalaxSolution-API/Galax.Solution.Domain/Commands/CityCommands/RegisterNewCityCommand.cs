using FluentValidation;
using Galax.Solution.Domain.Commands.Validations.CityValidations;
using System;


namespace Galax.Solution.Domain.Commands.CityCommands
{
    public class RegisterNewCityCommand : CityCommand
    {
        public RegisterNewCityCommand(string name, bool actived)
        {
            Name = name;
            Actived = actived;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewCityCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
        
    }
}