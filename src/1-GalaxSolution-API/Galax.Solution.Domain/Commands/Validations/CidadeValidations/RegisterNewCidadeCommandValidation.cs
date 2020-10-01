using FluentValidation.Results;
using Galax.Solution.Domain.Commands.CidadeCommands;
using System;

namespace Galax.Solution.Domain.Commands.Validations.CidadeValidations
{
    public class RegisterNewCidadeCommandValidation : CidadeValidation<RegisterNewCidadeCommand>
    {
        public RegisterNewCidadeCommandValidation()
        {
            ValidateNome();
            ValidateId();
        }
    }
}