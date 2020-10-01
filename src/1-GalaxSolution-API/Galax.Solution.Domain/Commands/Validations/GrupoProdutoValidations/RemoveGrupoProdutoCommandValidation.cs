using Galax.Solution.Domain.Commands.GrupoProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.GrupoProdutoValidations
{
    public class RemoveGrupoProdutoCommandValidation : GrupoProdutoValidation<RemoveGrupoProdutoCommand>
    {
        public RemoveGrupoProdutoCommandValidation() 
        {
            ValidateId();
        }
    }
}
