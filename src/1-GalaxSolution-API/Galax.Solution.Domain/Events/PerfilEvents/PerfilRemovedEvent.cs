using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.PerfilEvents
{
    public class PerfilRemovedEvent : Event
    {
        public PerfilRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
