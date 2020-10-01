using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.PaisEvents
{
    public class PaisRemovedEvent : Event
    {
        public PaisRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public Guid Id { get; set; }

    }
}
