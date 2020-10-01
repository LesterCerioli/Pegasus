using Galax.Solution.Domain.Commands.SaidaProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.SaidaProdutoValidations
{
    public class RemoveSaidaProdutoCommandValidation : SaidaProdutoValidation<SaidaProdutoCommand>
    {
        public RemoveSaidaProdutoCommandValidation() 
        {
            ValidateId();
        }
    }
}
