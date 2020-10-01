using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.FornecedorEvents
{
    public class FornecedorRemovedEvent : Event
    {
        public FornecedorRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = Id;

        }

        public Guid Id { get; set; }
    }
}
