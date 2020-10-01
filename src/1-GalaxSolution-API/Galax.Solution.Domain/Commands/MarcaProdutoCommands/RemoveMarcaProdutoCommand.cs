using Galax.Solution.Domain.Commands.Validations.MarcaProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.MarcaProdutoCommands
{
    public class RemoveMarcaProdutoCommand : MarcaProdutoCommand 
    {
        public RemoveMarcaProdutoCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveMarcaProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
