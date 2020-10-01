using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.SaidaProdutoEvents
{
    public class SaidaProdutoRemovedEvent : Event
    {
        public SaidaProdutoRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public Guid Id { get; set; }
    }
}
