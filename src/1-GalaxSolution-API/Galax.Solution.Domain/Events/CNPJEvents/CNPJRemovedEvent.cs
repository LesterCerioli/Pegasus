using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.CNPJEvents
{
    public class CNPJRemovedEvent : Event
    {
        public CNPJRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public Guid Id { get; set; }

    }
}
