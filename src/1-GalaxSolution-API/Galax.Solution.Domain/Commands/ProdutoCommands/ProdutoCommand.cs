using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.ProdutoCommands
{
    public abstract class ProdutoCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Codigo { get; protected set; }
        public string Nome { get; protected set; }
        public decimal PrecoCusto { get; protected set; }
        public decimal PrecoVenda { get; protected set; }
        public int QuantEstoque { get; protected set; }
        public bool Ativo { get; protected set; }
        public string Imagem { get; protected set; }

    }
}
