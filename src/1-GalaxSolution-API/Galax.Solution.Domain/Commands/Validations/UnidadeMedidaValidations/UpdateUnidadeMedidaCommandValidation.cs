using Galax.Solution.Domain.Commands.UnidadeMedidaCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.UnidadeMedidaValidations
{
    public class UpdateUnidadeMedidaCommandValidation : UnidadeMedidaValidation<UnidadeMedidaCommand>
    {
        public UpdateUnidadeMedidaCommandValidation() 
        {
            ValidateNome();
            ValidateSigla();
        }
    }
}
