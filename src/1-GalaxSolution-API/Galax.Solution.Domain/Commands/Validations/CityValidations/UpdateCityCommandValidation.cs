using FluentValidation.Results;
using Galax.Solution.Domain.Commands.CityCommands;
using System;

namespace Galax.Solution.Domain.Commands.Validations.CityValidations
{
    public class UpdateCityCommandValidation : CityValidation<UpdateCityCommand>
    {
        public UpdateCityCommandValidation()
        {
            ValidateId();
            ValidateName();
            
        }

        
    }
}