using Galax.Solution.Domain.Commands.InventarioEstoqueCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.InventarioEstoqueValidations
{
    public class UpdateInventarioEstoqueCommandValidation : InventarioEstoqueValidation<UpdateInventarioEstoqueCommand>
    {
        public UpdateInventarioEstoqueCommandValidation() 
        {
            ValidateId();
            ValidateMotivo();

        }
    }
}
