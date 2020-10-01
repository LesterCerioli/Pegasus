using Galax.Solution.Domain.Commands.Validations.InventarioEstoqueValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.InventarioEstoqueCommands
{
    public class RegisterNewInventarioEstoqueCommand : InventarioEstoqueCommand
    {
        public RegisterNewInventarioEstoqueCommand(DateTime data, string motivo, int qtdestoque, int quantidadeinventario) 
        {
            Data = data;
            Motivo = motivo;
            Qtdestoque = qtdestoque;
            QuantidadeInventario = quantidadeinventario;

        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewInventarioEstoqueCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
