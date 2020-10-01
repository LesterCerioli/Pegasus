using Galax.Solution.Domain.Commands.Validations.UsuarioEstoqueValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.UsuarioEstoqueCommands
{
    public class RemoveUsuarioEstoqueCommand : UsuarioEstoqueCommand 
    {
        public RemoveUsuarioEstoqueCommand(Guid id) 
        {
            Id = id;
            AggregateId = id; 
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveUsuarioEstoqueCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
