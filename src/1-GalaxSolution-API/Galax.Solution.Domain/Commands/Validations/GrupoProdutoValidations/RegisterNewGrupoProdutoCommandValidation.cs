using Galax.Solution.Domain.Commands.GrupoProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.GrupoProdutoValidations
{
    public class RegisterNewGrupoProdutoCommandValidation : GrupoProdutoValidation<RegisterNewGrupoProdutoCommand>
    {
        public RegisterNewGrupoProdutoCommandValidation() 
        {
            ValidateId();
            ValidateNome();

        }
    }
}
