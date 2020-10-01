using NetDevPack.Messaging;
using System;

namespace Galax.Solution.Domain.Events.CidadeEvent
{
    public class CidadeUpdatedEvent : Event
    {
        public CidadeUpdatedEvent(Guid id, string name) 
        {
            Id = id;
            Name = name;
            AggregateId = id;

        }

        public Guid Id { get; set; }

        public string Name { get; private set; }

    }
}