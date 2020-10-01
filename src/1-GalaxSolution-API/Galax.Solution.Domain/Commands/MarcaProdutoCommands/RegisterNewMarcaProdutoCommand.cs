using Galax.Solution.Domain.Commands.Validations.CidadeValidations;
using Galax.Solution.Domain.Commands.Validations.MarcaProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.MarcaProdutoCommands
{
    public class RegisterNewMarcaProdutoCommand : MarcaProdutoCommand
    {
        public RegisterNewMarcaProdutoCommand(string nome) 
        {
            Nome = nome;

        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewMarcaProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }




    }
}
