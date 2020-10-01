using Galax.Solution.Domain.Commands.UsuarioEstoqueCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.UsuarioEstoqueValidations
{
    public class RemoveUsuarioEstoqueCommandValidation : UsuarioEstoqueValidation<UsuarioEstoqueCommand>
    {
        public RemoveUsuarioEstoqueCommandValidation() 
        {
            ValidateId();
        }
    }
}
