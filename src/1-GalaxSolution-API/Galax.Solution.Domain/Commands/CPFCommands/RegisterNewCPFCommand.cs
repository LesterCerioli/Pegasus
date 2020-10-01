using Galax.Solution.Domain.Commands.Validations.CPFValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.CPFCommands
{
    public class RegisterNewCPFCommand : CPFCommand
    {
        public RegisterNewCPFCommand(string numCPF) 
        {
            NumCPF = numCPF;

        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewCPFCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
