using Galax.Solution.Domain.Commands.Validations.EntradaProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.EntradaProdutoCommands
{
    public class RegisterNewEntradaProdutoCommand : EntradaProdutoCommand 
    {
        public RegisterNewEntradaProdutoCommand(string numero, DateTime data, int quantidade) 
        {
            Numero = numero;
            Data = data;
            Quantidade = quantidade;

        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewEntradaProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
