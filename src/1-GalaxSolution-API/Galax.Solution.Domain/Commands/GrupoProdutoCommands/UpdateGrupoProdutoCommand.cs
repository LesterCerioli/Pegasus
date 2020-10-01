using Galax.Solution.Domain.Commands.FornecedorCommandsS;
using Galax.Solution.Domain.Commands.Validations.GrupoProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.GrupoProdutoCommands
{
    public class UpdateGrupoProdutoCommand : GrupoProdutoCommand
    {
        public UpdateGrupoProdutoCommand(Guid id, string nome, bool ativo) 
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;

        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateGrupoProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
