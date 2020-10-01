using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.GrupoProdutoEvents
{
    public class GrupoProdutoUpdatedEvent : Event
    {
        public GrupoProdutoUpdatedEvent(Guid id, string nome, bool ativo) 
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;
            AggregateId = id;

        }

        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }
    }
}
