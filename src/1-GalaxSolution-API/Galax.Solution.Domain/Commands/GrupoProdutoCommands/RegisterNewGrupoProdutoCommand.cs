using Galax.Solution.Domain.Commands.Validations.GrupoProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.GrupoProdutoCommands
{
    public class RegisterNewGrupoProdutoCommand : GrupoProdutoCommand
    {
        public RegisterNewGrupoProdutoCommand(string nome, bool ativo) 
        {
            Nome = nome;
            Ativo = ativo;

        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewGrupoProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }


}
   




