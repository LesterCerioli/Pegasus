using Galax.Solution.Domain.Commands.Validations.PaisValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.PaisCommands
{
    public class UpdatePaisCommand : PaisCommand
    {
        public UpdatePaisCommand(Guid id, string nome, string codigo, bool ativo )
        {
            Id = id;
            Nome = nome;
            Codigo = codigo;
            Ativo = ativo;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdatePaisCommandValidation().Validate(this);
            return ValidationResult.IsValid;

        }



    }
}

