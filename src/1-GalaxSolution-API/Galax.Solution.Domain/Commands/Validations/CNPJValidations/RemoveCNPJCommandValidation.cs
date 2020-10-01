using Galax.Solution.Domain.Commands.CNPJCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.CNPJValidations
{
    public class RemoveCNPJCommandValidation : CNPJValidation<RemoveCNPJCommand>
    {
        public RemoveCNPJCommandValidation() 
        {
            ValidateId();
        }
    }
}
