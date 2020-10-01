using Galax.Solution.Domain.Commands.Validations.UnidadeMedidaValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.UnidadeMedidaCommands
{
    public class RegisterNewUnidadeMedidaCommand : UnidadeMedidaCommand
    {
        public RegisterNewUnidadeMedidaCommand(string nome, string sigla, bool ativo) 
        {
            Nome = nome;
            Sigla = sigla;
            Ativo = ativo;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewUnidadeMedidaCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
