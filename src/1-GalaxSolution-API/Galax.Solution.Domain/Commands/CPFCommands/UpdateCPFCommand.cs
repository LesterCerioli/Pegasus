using FluentValidation;
using Galax.Solution.Domain.Commands.Validations.CPFValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.CPFCommands
{
    public class UpdateCPFCommand : CPFCommand
    {
        public UpdateCPFCommand(Guid id, string numCPF) 
        {
            Id = id;
            NumCPF = numCPF;

        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateCPFCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }


    }
}
