using Galax.Solution.Domain.Commands.Validations.LocalArmazenamentoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.LocalArmazenamentoCommands
{
    public class RemoveLocalArmazenamentoCommand : LocalArmazenamentoCommand
    {
        public RemoveLocalArmazenamentoCommand(Guid id) 
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveLocalArmazenamentoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
