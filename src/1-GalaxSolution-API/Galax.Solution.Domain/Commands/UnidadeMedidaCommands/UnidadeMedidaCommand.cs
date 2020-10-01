using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Galax.Solution.Domain.Commands.UnidadeMedidaCommands
{
    public abstract class UnidadeMedidaCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Sigla { get; protected set; }
        public bool Ativo { get; protected set; }

        
    }
}
