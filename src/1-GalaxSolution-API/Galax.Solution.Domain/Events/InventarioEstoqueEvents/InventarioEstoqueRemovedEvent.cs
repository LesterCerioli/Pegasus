using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.InventarioEstoqueEvents
{
    public class InventarioEstoqueRemovedEvent : Event
    {
        public InventarioEstoqueRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }

        public Guid Id { get; set; }
    }
}
