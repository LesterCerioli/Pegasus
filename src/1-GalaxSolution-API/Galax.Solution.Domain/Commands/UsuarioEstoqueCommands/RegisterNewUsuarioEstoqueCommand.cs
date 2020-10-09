using Galax.Solution.Domain.Commands.Validations.UsuarioEstoqueValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.UsuarioEstoqueCommands
{
    public class RegisterNewUsuarioEstoqueCommand : UsuarioEstoqueCommand
    {
<<<<<<< HEAD
        public RegisterNewUsuarioEstoqueCommand(Guid id, string login, string senha, string nome, string nomeMeio, string sobreNome, string email, string telefone)
=======
        public RegisterNewUsuarioEstoqueCommand(Guid id, string login, string senha, string nome, string nomeMeio, string sobreNome, string email)
>>>>>>> master
        {
            Id = id;
            Login = login;
            Senha = senha;
            Nome = nome;
            NomeMeio = nomeMeio;
            SobreNome = sobreNome;
            Email = email;
<<<<<<< HEAD
            Telefone = telefone;
=======
>>>>>>> master
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewUsuarioEstoqueCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
