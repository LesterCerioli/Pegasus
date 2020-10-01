using Galax.Solution.Domain.Commands.SaidaProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.SaidaProdutoValidations
{
    public class UpdateSaidaProdutoCommandValidation : SaidaProdutoValidation<UpdateSaidaProdutoCommand>
    {
        public UpdateSaidaProdutoCommandValidation() 
        {
            ValidateId();
            ValidateNumero();
            ValidateData();
            ValidateQuantidade();

        }
    }
}
