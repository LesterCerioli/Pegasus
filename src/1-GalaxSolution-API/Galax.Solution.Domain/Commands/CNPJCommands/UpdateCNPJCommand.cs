using System;
using Galax.Solution.Domain.Commands.Validations.CidadeValidations;
using Galax.Solution.Domain.Commands.Validations.CNPJValidations;

namespace Galax.Solution.Domain.Commands.CNPJCommands
{
    public class UpdateCNPJCommand : CNPJCommand
    {
        public UpdateCNPJCommand(Guid id, string numCNPJ) 
        {
            Id = id;
            NumCNPJ = numCNPJ;

        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateCNPJCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}