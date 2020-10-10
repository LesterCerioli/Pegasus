using Galax.Solution.Domain.Commands.Validations.EstadoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.EstadoCommands
{
    public class UpdateEstadoCommand : EstadoCommand
    {
        public UpdateEstadoCommand(Guid id, string nome, string uf ,bool ativo) 
        {
            Id = id;
            Nome = nome;
            UF = uf;
            Ativo = ativo;

        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateEstadoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
