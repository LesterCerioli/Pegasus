using System;
using Galax.Solution.Domain.Entities;
using NetDevPack.Messaging;


namespace Galax.Solution.Domain.Commands.CNPJCommands
{
    public abstract class CNPJCommand : Command
    {
        public Guid Id { get; protected set; }
        public string NumCNPJ {get; protected set;}
        
        
    }
}