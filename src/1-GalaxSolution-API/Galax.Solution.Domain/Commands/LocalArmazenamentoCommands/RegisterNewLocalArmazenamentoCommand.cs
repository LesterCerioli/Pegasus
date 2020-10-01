using Galax.Solution.Domain.Commands.Validations.LocalArmazenamentoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.LocalArmazenamentoCommands
{
    public class RegisterNewLocalArmazenamentoCommand : LocalArmazenamentoCommand
    {
        public RegisterNewLocalArmazenamentoCommand(string nome) 
        {
            Nome = nome;

        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewLocalArmazenamentoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
