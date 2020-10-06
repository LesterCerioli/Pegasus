using NetDevPack.Messaging;
using System;
using MediatR;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.CidadeEvent
{
    public class CityRemovedEvent : Event
    {
        public CityRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }

    }
}
