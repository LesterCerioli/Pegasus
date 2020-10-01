using System;
using NetDevPack.Messaging;


namespace Galax.Solution.Domain.Commands.CPFCommands
{
    public abstract class CPFCommand : Command
    {
        public Guid Id { get; protected set; }
        public string NumCPF {get; protected set;}
        
    }
}