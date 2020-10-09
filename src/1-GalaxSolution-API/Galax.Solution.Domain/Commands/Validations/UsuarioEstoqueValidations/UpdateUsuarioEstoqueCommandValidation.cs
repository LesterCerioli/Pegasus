using Galax.Solution.Domain.Commands.UsuarioEstoqueCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.UsuarioEstoqueValidations
{
    public class UpdateUsuarioEstoqueCommandValidation : UsuarioEstoqueValidation<UsuarioEstoqueCommand>
    {
        public UpdateUsuarioEstoqueCommandValidation() 
        {
            ValidateLogin();
            ValidateSenha();
            ValidateNome();
            ValidateNomeMeio();
            ValidateSobreNome();
            ValidateEmail();
<<<<<<< HEAD
            ValidateTelefone();

=======
>>>>>>> master


        }

    }
}
