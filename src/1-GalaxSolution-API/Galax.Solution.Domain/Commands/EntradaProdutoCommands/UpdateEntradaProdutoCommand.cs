using Galax.Solution.Domain.Commands.Validations.EntradaProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.EntradaProdutoCommands
{
    public class UpdateEntradaProdutoCommand : EntradaProdutoCommand
    {
        public UpdateEntradaProdutoCommand(Guid id, string numero, DateTime data, int quantidade) 
        {
            Id = id;
            Numero = numero;
            Data = data; 
            Quantidade = quantidade;

        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateEntradaProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
