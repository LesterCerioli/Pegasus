using System;
using Galax.Solution.Domain.Entities;
using NetDevPack.Messaging;


namespace Galax.Solution.Domain.Commands.EntradaProdutoCommands
{
    public abstract class EntradaProdutoCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Numero { get; protected set; }
        public DateTime Data { get; protected set; }
        public int Quantidade { get; protected set; }
        

        
    }
}