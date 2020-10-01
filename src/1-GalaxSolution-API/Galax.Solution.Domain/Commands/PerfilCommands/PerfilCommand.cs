using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.PerfilCommands
{
    public abstract class PerfilCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
        public bool Ativo { get; protected set; }

    }
}
