using Galax.Solution.Domain.Commands.MarcaProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.MarcaProdutoValidations
{
    public class UpdateMarcaProdutoCommandValidation : MarcaProdutoValidation<UpdateMarcaProdutoCommand>
    {
        public UpdateMarcaProdutoCommandValidation() 
        {
            ValidateId();
            ValidateNome();

        }
    }
}
