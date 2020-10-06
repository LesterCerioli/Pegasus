using Galax.Solution.Domain.Commands.CityCommands;


namespace Galax.Solution.Domain.Commands.Validations.CityValidations
{
    public class RegisterNewCityCommandValidation : CityValidation<RegisterNewCityCommand>
    {
        public RegisterNewCityCommandValidation()
        {
            ValidateName();
            ValidateId();
        }
    }
}