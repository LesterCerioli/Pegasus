﻿using Galax.Solution.Domain.Commands.PaisCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.PaisValidation
{
    public class UpdatePaisCommandValidation : PaisValidation<UpdatePaisCommand>
    {
        public UpdatePaisCommandValidation() 
        {
            ValidateId();
            ValidateNome();
            ValidateCodigo();
        }
    }
}
