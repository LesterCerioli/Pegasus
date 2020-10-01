using Galax.Solution.Domain.Commands.FornecedorCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.FornecedorValidations
{
    public class RemoveFornecedorCommandValidation : FornecedorValidation<RemoveFornecedorCommand>
    {
        public RemoveFornecedorCommandValidation()  
        {
            ValidateId();

        }
    }
}
