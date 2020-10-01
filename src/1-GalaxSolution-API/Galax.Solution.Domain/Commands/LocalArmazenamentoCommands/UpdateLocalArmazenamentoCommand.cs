using Galax.Solution.Domain.Commands.Validations.LocalArmazenamentoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.LocalArmazenamentoCommands
{
    public class UpdateLocalArmazenamentoCommand : LocalArmazenamentoCommand
    {
        public UpdateLocalArmazenamentoCommand(Guid id, string nome, bool ativo) 
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateLocalArmazenamentoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
