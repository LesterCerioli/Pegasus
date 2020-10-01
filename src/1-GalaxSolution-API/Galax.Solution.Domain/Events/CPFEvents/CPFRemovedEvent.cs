using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.CPFEvents
{
    public class CPFRemovedEvent : Event
    {
        public CPFRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }

    }
}
