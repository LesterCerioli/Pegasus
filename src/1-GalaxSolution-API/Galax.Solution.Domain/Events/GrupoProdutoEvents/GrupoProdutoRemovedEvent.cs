using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.GrupoProdutoEvents
{
    public class GrupoProdutoRemovedEvent : Event
    {
        public GrupoProdutoRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public Guid Id { get; set; }
    }
}
