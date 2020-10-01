using Galax.Solution.Domain.Commands.MarcaProdutoCommands;
using Galax.Solution.Domain.Commands.Validations.MarcaProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.MarcaProdutoCommands
{
    public class UpdateMarcaProdutoCommand : MarcaProdutoCommand 
    {
        public UpdateMarcaProdutoCommand(Guid id, string nome, bool ativo) 
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;

        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateMarcaProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
    
}
