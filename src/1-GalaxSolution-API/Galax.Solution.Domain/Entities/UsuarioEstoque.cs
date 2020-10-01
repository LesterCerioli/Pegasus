using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class UsuarioEstoque : Entity, IAggregateRoot
    {


        public UsuarioEstoque(Guid id, string login, string senha, string nome, string nomemeio, string sobrenome, string email )
        {
            Id = id;
            Login = login;
            Senha = senha;
            Nome = nome;
            NomeMeio = nomemeio;
            Sobrenome = sobrenome;
            Email = email;
        }
        
        protected UsuarioEstoque() { }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string NomeMeio { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public virtual List<Perfil> Perfis { get; set; }


        
    }
}
