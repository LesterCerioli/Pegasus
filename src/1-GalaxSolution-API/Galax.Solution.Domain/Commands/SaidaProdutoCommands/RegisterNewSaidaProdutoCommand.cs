using FluentValidation;
using Galax.Solution.Domain.Commands.Validations.SaidaProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.SaidaProdutoCommands
{
    public class RegisterNewSaidaProdutoCommand : SaidaProdutoCommand
    {
        public RegisterNewSaidaProdutoCommand(string numero, DateTime data, int quantidade) 
        {
            Numero = numero;
            Data = data;
            Quantidade = quantidade;

        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewSaidaProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
