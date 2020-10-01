using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.EstadoEvents
{
    public class EstadoRemovedEvent : Event
    {
        public EstadoRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public Guid Id { get; set; }

    }
}
