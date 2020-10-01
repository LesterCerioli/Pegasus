using FluentValidation.Results;
using Galax.Solution.Domain.Commands.CPFCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.CPFValidations
{
    public class UpdateCPFCommandValidation : CPFValidation<UpdateCPFCommand>
    {
        public UpdateCPFCommandValidation() 
        {
            ValidateId();
            ValidateNumCPF();
        }

        
        
    }
}
