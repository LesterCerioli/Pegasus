using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.ProdutoEvents
{
    public class ProdutoRemovedEvent : Event
    {
        public ProdutoRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public Guid Id { get; set; }

    }
}
