using Galax.Solution.Domain.Commands.EstadoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.EstadoValidations
{
    public class RemoveEstadoCommandValidation : EstadoValidation<RemoveEstadoCommand>
    {
        public RemoveEstadoCommandValidation() 
        {
            ValidateId();
        }

    }
}
