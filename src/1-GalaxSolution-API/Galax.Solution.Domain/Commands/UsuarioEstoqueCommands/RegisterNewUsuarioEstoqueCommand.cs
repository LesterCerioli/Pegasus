using Galax.Solution.Domain.Commands.Validations.UsuarioEstoqueValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.UsuarioEstoqueCommands
{
    public class RegisterNewUsuarioEstoqueCommand : UsuarioEstoqueCommand
    {
        public RegisterNewUsuarioEstoqueCommand(Guid id, string login, string senha, string nome, string nomeMeio, string sobreNome, string email, string telefone)
        {
            Id = id;
            Login = login;
            Senha = senha;
            Nome = nome;
            NomeMeio = nomeMeio;
            SobreNome = sobreNome;
            Email = email;
            Telefone = telefone;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewUsuarioEstoqueCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
