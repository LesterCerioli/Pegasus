using System;
using Galax.Solution.Domain.Entities;
using NetDevPack.Messaging;


namespace Galax.Solution.Domain.Commands.StateCommands
{
    public abstract class StateCommand : Command
    {
        public Guid Id { get; protected set; } 
        public string Name { get; protected set; }
        public string UF { get; protected set; }
        public bool Actived { get; protected set; }
          
    }
    
    
}