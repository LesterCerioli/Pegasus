using System;
using Galax.Solution.Domain.Entities;
using NetDevPack.Messaging;


namespace Galax.Solution.Domain.Commands.CidadeCommands
{
    public abstract class CidadeCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
        public bool Ativo { get; protected set; }
        

        

        
    }
}