using Galax.Solution.Domain.Commands.FornecedorCommandsS;
using Galax.Solution.Domain.Commands.Validations.FornecedorValidations;
using System;

namespace Galax.Solution.Domain.Commands.FornecedorCommands
{
    public class RemoveFornecedorCommand : FornecedorCommand
    {
        public RemoveFornecedorCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveFornecedorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}
