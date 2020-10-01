using Galax.Solution.Domain.Commands.MarcaProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.MarcaProdutoValidations
{
    public class RegisterNewMarcaProdutoCommandValidation : MarcaProdutoValidation<RegisterNewMarcaProdutoCommand>
    {
        public RegisterNewMarcaProdutoCommandValidation() 
        {
            ValidateId();
            ValidateNome();
        }
    }
}
