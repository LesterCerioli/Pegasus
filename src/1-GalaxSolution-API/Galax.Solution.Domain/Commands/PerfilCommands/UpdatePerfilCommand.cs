using FluentValidation.Results;
using Galax.Solution.Domain.Commands.Validations.PerfilValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.PerfilCommands
{
    public class UpdatePerfilCommand : PerfilCommand
    {
        public UpdatePerfilCommand(Guid id, string nome) 
        {
            Id = id;
            Nome = nome;

        }

        public override bool IsValid() 
        {
            ValidationResult = new UpdatePerfilCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }


    }
}
