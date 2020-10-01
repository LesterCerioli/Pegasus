using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.UsuarioEstoqueCommands
{
    public abstract class UsuarioEstoqueCommand : Command 
    {
        public Guid Id { get; protected set; }
        public string Login { get; protected set; }
        public string Senha { get; protected set; }
        public string Nome { get; protected set; }
        public string NomeMeio { get; protected set; }
        public string SobreNome { get; protected set; }
        public string Email { get; protected set; }
    }
}
