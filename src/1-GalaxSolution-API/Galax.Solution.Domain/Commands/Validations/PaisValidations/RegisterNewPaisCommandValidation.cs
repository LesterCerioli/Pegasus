using Galax.Solution.Domain.Commands.PaisCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.PaisValidation
{
    public class RegisterNewPaisCommandValidation : PaisValidation<RegisterNewPaisCommand>
    {
        public RegisterNewPaisCommandValidation() 
        {
            ValidateId();
            ValidateNome();
            ValidateCodigo();
        }
    }
}
