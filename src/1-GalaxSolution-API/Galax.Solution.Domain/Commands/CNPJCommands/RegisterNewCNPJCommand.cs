using System;
using Galax.Solution.Domain.Commands.Validations.CidadeValidations;
using Galax.Solution.Domain.Commands.Validations.CNPJValidations;

namespace Galax.Solution.Domain.Commands.CNPJCommands
{
    public class RegisterNewCNPJCommand : CNPJCommand
    {
        public RegisterNewCNPJCommand(string numCNPJ) 
        {
            NumCNPJ = numCNPJ;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewCNPJCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}