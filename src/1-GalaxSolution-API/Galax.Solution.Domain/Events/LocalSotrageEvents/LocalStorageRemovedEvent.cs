using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.LocalStorageEvents
{
    public class LocalStorageRemovedEvent : Event
    {
        public LocalStorageRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public Guid Id { get; set; }
    }
}
