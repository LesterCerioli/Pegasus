using Galax.Solution.Domain.Commands.Validations.PaisValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.PaisCommands
{
    public class RegisterNewPaisCommand : PaisCommand
    {
        public RegisterNewPaisCommand(string nome, string codigo) 
        {
            Nome = nome;
            Codigo = codigo;

        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewPaisCommandValidation().Validate(this);
            return ValidationResult.IsValid;

        }

    }
}
