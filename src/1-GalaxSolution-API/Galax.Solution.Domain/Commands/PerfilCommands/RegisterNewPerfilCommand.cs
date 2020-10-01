using FluentValidation.Results;
using Galax.Solution.Domain.Commands.Validations.PerfilValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.PerfilCommands
{
    public class RegisterNewPerfilCommand : PerfilCommand
    {
        public RegisterNewPerfilCommand(string nome) 
        {
            Nome = nome;

        }
        public override bool IsValid() 
        {
            ValidationResult = new RegisterNewPerfilCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
