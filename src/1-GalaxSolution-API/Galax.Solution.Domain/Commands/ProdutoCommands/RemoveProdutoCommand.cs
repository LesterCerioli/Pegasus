using Galax.Solution.Domain.Commands.Validations.ProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.ProdutoCommands
{
    public class RemoveProdutoCommand : ProdutoCommand 
    {
        public RemoveProdutoCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
