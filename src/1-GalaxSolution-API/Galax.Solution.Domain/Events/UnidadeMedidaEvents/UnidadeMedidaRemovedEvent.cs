using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.UnidadeMedidaEvents
{
    public class UnidadeMedidaRemovedEvent : Event
    {
        public UnidadeMedidaRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
