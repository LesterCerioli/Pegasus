using Galax.Solution.Domain.Commands.Validations.GrupoProdutoValidations;
using System;

namespace Galax.Solution.Domain.Commands.GrupoProdutoCommands
{
    public class RemoveGrupoProdutoCommand : GrupoProdutoCommand
    {
        public RemoveGrupoProdutoCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveGrupoProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
