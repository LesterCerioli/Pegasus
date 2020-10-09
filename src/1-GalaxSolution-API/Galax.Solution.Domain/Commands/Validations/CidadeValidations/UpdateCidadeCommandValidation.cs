using FluentValidation.Results;
using Galax.Solution.Domain.Commands.CidadeCommands;
using System;

namespace Galax.Solution.Domain.Commands.Validations.CidadeValidations
{
    public class UpdateCidadeCommandValidation : CidadeValidation<UpdateCidadeCommand>
    {
        public UpdateCidadeCommandValidation()
        {
            ValidateId();
            ValidateNome();
            
        }
    }
}