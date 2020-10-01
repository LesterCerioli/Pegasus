using Galax.Solution.Domain.Commands.EntradaProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.EntradaProdutoValidations
{
    public class UpdateEntradaProdutoCommandValidation : EntradaProdutoValidation<EntradaProdutoCommand>
    {
        public UpdateEntradaProdutoCommandValidation() 
        {
            ValidateId();
            ValidateNumero();
        }
    }
}
