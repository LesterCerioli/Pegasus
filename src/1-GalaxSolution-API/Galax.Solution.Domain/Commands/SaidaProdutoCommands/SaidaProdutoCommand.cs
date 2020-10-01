using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.SaidaProdutoCommands
{
    public abstract class SaidaProdutoCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Numero { get; protected set; }
        public DateTime Data { get; protected set; }
        public int Quantidade { get; protected set; }


    }
}
