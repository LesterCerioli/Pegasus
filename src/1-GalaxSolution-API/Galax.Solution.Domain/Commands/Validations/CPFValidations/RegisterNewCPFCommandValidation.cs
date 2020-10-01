using Galax.Solution.Domain.Commands.CPFCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.CPFValidations
{
    public class RegisterNewCPFCommandValidation : CPFValidation<RegisterNewCPFCommand> 
    {
        public RegisterNewCPFCommandValidation() 
        {
            ValidateNumCPF();
            ValidateId();
        }

      
    }
}
