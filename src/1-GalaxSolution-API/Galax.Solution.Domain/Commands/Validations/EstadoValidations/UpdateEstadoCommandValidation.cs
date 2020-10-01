using Galax.Solution.Domain.Commands.EstadoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.EstadoValidations
{
    public class UpdateEstadoCommandValidation : EstadoValidation<UpdateEstadoCommand>
    {
        public UpdateEstadoCommandValidation()
        {
            ValidateNome();
            ValidateId();
            ValidateUF();

        }
    }
}
