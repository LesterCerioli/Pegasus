using Galax.Solution.Domain.Commands.Validations.InventarioEstoqueValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.InventarioEstoqueCommands
{
    public class UpdateInventarioEstoqueCommand : InventarioEstoqueCommand
    {
        public UpdateInventarioEstoqueCommand(Guid id, DateTime data, string motivo, int qtdestoque, int quantidadeinventario) 
        {
            Id = id;
            Data = data;
            Motivo = motivo;
            Qtdestoque = qtdestoque;
            QuantidadeInventario = quantidadeinventario;

        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateInventarioEstoqueCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
