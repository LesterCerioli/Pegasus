using Galax.Solution.Domain.Commands.LocalArmazenamentoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.LocalArmazenamentoValidations
{
    public class RemoveLocalArmazenamentoCommandValidation : LocalArmazenamentoValidation<RemoveLocalArmazenamentoCommand>
    {
        public RemoveLocalArmazenamentoCommandValidation() 
        {
            ValidateId();

        }
    }
}
