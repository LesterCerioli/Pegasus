using Galax.Solution.Domain.Commands.PerfilCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.PerfilValidations
{
    public class RemovePerfilCommandValidation : PerfilValidation<PerfilCommand>
    {
        public RemovePerfilCommandValidation() 
        {
            ValidateId();

        }
    }
}
