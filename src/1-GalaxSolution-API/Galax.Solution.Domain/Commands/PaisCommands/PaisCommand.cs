using System;
using NetDevPack.Messaging;



namespace Galax.Solution.Domain.Commands.PaisCommands
{
    public abstract class PaisCommand : Command
    {
        public Guid Id {get; protected set;}
        public string Nome { get; protected set; }
        public string Codigo { get; protected set; }
        public bool Ativo { get; protected set; }
        
    }
}