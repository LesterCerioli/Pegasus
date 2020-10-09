using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.ProductInputEvents
{
    public class ProductInputRemovedEvent : Event
    {
        public ProductInputRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; } 
    }
}
