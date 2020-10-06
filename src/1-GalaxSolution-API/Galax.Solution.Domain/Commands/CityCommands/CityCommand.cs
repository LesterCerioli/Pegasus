using System;
using Galax.Solution.Domain.Entities;
using NetDevPack.Messaging;


namespace Galax.Solution.Domain.Commands.CityCommands
{
    public abstract class CityCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public bool Actived { get; protected set; }
        

        

        
    }
}