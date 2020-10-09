using System;
using Galax.Solution.Domain.Commands.Validations.CidadeValidations;

namespace Galax.Solution.Domain.Commands.CidadeCommands
{
    public class RegisterNewCidadeCommand : CidadeCommand
    {
        public RegisterNewCidadeCommand(string nome, bool ativo)
        {
            Nome = nome;
            Ativo = ativo;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewCidadeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
        
    }
}