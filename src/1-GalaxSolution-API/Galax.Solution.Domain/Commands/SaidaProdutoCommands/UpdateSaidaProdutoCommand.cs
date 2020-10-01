using Galax.Solution.Domain.Commands.Validations.SaidaProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.SaidaProdutoCommands
{
    public class UpdateSaidaProdutoCommand : SaidaProdutoCommand
    {
        public UpdateSaidaProdutoCommand(Guid id, string numero, DateTime data, int quantidade) 
        {
            Id = id;
            Numero = numero;
            Data = data;
            Quantidade = quantidade;

        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateSaidaProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
