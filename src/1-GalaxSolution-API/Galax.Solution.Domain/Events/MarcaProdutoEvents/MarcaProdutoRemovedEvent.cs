using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.MarcaProdutoEvents
{
    public class MarcaProdutoRemovedEvent : Event
    {
        public MarcaProdutoRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public Guid Id { get; set; }

    }
}
