using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.UsuarioEstoqueEvents
{
    public class UsuarioEstoqueRegisteredEvent : Event
    {
        public UsuarioEstoqueRegisteredEvent(Guid id, string login, string senha, string nome, string nomeMeio, string sobreNome, string email)
        {
            Id = id;
            Login = login;
            Senha = senha;
            Nome = nome;
            NomeMeio = nomeMeio;
            SobreNome = sobreNome;
            Email = email;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public string Nome { get; private set; }
        public string NomeMeio { get; private set; }
        public string SobreNome { get; private set; }
        public string Email { get; private set; }

    }
}
