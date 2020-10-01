using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.InventarioEstoqueEvents
{
    public class InventarioEstoqueRegisteredEvent : Event
    {
        public InventarioEstoqueRegisteredEvent(Guid id, string motivo)
        {
            Id = id;
            Motivo = motivo;
            AggregateId = id;

        }

        public Guid Id { get; set; }

        public string Motivo { get; private set; }

    }
}
