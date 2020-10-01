using Galax.Solution.Domain.Commands.Validations.CidadeValidations;
using System;

namespace Galax.Solution.Domain.Commands.CidadeCommands
{
    public class UpdateCidadeCommand : CidadeCommand
    {
        public UpdateCidadeCommand(Guid id, string nome, bool ativo)
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateCidadeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
        
    }
}