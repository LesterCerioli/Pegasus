using Galax.Solution.Domain.Commands.EntradaProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.EntradaProdutoValidations
{
    public class RemoveEntradaProdutoCommandValidation : EntradaProdutoValidation<RemoveEntradaProdutoCommand>
    {
        public RemoveEntradaProdutoCommandValidation() 
        {
            ValidateId();
        }
    }
}
