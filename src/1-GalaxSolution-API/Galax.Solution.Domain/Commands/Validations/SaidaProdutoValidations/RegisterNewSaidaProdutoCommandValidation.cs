using Galax.Solution.Domain.Commands.SaidaProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.SaidaProdutoValidations
{
    public class RegisterNewSaidaProdutoCommandValidation : SaidaProdutoValidation<SaidaProdutoCommand>
    {
        public RegisterNewSaidaProdutoCommandValidation() 
        {
            ValidateId();
            ValidateNumero();
            ValidateData();
            ValidateQuantidade();

        }
    }
}
