using Galax.Solution.Domain.Commands.Validations.UnidadeMedidaValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.UnidadeMedidaCommands
{
    public class UpdateUnidadeMedidaCommand : UnidadeMedidaCommand
    {
        public UpdateUnidadeMedidaCommand(Guid id, string nome) 
        {
            Id = id;
            Nome = nome;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateUnidadeMedidaCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
