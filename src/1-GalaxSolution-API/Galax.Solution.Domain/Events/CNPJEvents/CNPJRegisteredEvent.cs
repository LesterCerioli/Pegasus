using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.CNPJEvents
{
    public class CNPJRegisteredEvent : Event
    {
        public CNPJRegisteredEvent(Guid id, string numCNPJ) 
        {
            Id = id;
            NumCNPJ = numCNPJ;
            AggregateId = id;

        }

        public Guid Id { get; set; }
        public string NumCNPJ { get; private set; }
    }
}
