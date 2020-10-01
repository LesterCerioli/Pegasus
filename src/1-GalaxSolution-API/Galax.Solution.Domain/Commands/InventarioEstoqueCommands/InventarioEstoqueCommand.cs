using System;
using Galax.Solution.Domain.Entities;
using NetDevPack.Messaging;


namespace Galax.Solution.Domain.Commands.InventarioEstoqueCommands
{
    public abstract class InventarioEstoqueCommand : Command
    {
        public Guid Id { get; protected set; }
        public DateTime Data { get; protected set; }
        public string Motivo { get; protected set; }
        public int Qtdestoque{ get; protected set; }
        public int QuantidadeInventario { get; protected set; }
        
        
    }
}