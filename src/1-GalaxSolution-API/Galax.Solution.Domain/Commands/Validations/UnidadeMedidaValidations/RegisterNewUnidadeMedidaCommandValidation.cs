using Galax.Solution.Domain.Commands.UnidadeMedidaCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.UnidadeMedidaValidations
{
    public class RegisterNewUnidadeMedidaCommandValidation : UnidadeMedidaValidation<UnidadeMedidaCommand>
    {
        public RegisterNewUnidadeMedidaCommandValidation() 
        {
            ValidateNome();
            ValidateSigla();
        }
    }
}
