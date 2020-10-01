using Galax.Solution.Domain.Commands.Validations.InventarioEstoqueValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.InventarioEstoqueCommands
{
    public class RemoveInventarioEstoqueCommand : InventarioEstoqueCommand
    {
        public RemoveInventarioEstoqueCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveInventarioEstoqueCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
