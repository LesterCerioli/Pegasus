using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.LocalArmazenamentoEvents
{
    public class LocalArmazenamentoRemovedEvent : Event
    {
        public LocalArmazenamentoRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public Guid Id { get; set; }
    }
}
