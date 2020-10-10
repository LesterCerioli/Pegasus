using Galax.Solution.Domain.Commands.Validations.EstadoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.StateCommands
{
    public class RegisterNewStateCommand : StateCommand
    {
        public RegisterNewStateCommand(Guid id, string name, string uf, bool aactived)
        {
            Id = id;
            Name = name;
            UF = uf;
            Actived = aactived;

        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewStateCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}