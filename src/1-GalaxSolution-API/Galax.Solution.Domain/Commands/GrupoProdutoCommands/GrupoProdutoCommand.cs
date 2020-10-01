using System;
using NetDevPack.Messaging;


namespace Galax.Solution.Domain.Commands.GrupoProdutoCommands
{
    public class GrupoProdutoCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
        public bool Ativo { get; protected set; }
        
    }
}