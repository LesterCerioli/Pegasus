using Galax.Solution.Domain.Entities;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.CidadeEvent
{
    public class CityRegisteredEvent : Event
    {
        public CityRegisteredEvent(Guid id, string name, bool ativo)
        {
            Id = id;
            Name = name;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        public string Name { get; private set; }
       
    }
}
