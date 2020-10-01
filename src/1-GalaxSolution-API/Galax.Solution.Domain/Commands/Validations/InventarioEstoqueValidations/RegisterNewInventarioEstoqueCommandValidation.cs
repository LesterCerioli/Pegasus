using Galax.Solution.Domain.Commands.InventarioEstoqueCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.InventarioEstoqueValidations
{
    public class RegisterNewInventarioEstoqueCommandValidation : InventarioEstoqueValidation<RegisterNewInventarioEstoqueCommand>
    {
        public RegisterNewInventarioEstoqueCommandValidation()
        {
            ValidateId();
            ValidateMotivo();

        }
    }
}
