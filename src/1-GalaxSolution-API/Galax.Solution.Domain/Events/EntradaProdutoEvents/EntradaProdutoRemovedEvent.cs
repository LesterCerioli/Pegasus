using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.EntradaProdutoEvents
{
    public class EntradaProdutoRemovedEvent : Event
    {
        public EntradaProdutoRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; } 
    }
}
