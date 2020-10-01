using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.ProdutoEvents
{
    public class ProdutoRegisteredEvent : Event
    {
        public ProdutoRegisteredEvent(Guid id, string nome, string codigo, decimal precoCusto, decimal precoVenda, int quantEstoque, bool ativo, string imagem)
        {
            Id = id;
            Nome = nome;
            Codigo = codigo;
            PrecoCusto = precoCusto;
            PrecoVenda = precoVenda;
            QuantEstoque = quantEstoque;
            Ativo = ativo;
            Imagem = imagem;
            AggregateId = id;

        }

        public Guid Id { get; set; }
        public string Codigo { get;private set; }
        public string Nome { get; private set; }
        public decimal PrecoCusto { get; private set; }
        public decimal PrecoVenda { get; private set; }
        public int QuantEstoque { get; private set; }
        public bool Ativo { get; private set; }
        public string Imagem { get; private set; }

    }



}

