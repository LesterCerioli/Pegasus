using Galax.Solution.Domain.Commands.UnidadeMedidaCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.UnidadeMedidaValidations
{
    public class RemoveUnidadeMedidaCommandValidation : UnidadeMedidaValidation<UnidadeMedidaCommand>
    {
        public RemoveUnidadeMedidaCommandValidation() 
        {
            ValidateId();
        }
    }
}
