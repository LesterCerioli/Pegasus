using Galax.Solution.Domain.Commands.MarcaProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.MarcaProdutoValidations
{
    public class RemoveMarcaProdutoCommandValidation : MarcaProdutoValidation<RemoveMarcaProdutoCommand>
    {
        public RemoveMarcaProdutoCommandValidation() 
        {
            ValidateId();
        }
    }
}
