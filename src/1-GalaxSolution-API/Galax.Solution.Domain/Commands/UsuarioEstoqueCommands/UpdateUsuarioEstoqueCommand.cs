using Galax.Solution.Domain.Commands.Validations.UsuarioEstoqueValidations;
using System;


namespace Galax.Solution.Domain.Commands.UsuarioEstoqueCommands
{
    public class UpdateUsuarioEstoqueCommand : UsuarioEstoqueCommand
    {
        public UpdateUsuarioEstoqueCommand(Guid id, string login, string senha, string nome, string nomeMeio, string sobrenome, string email) 
        {
            Id = id;
            Login = login;
            Senha = senha;
            Nome = nome;
            NomeMeio = nomeMeio;
            SobreNome = sobrenome;

        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateUsuarioEstoqueCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}
