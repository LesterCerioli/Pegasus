using NetDevPack.Messaging;
using System;

namespace Galax.Solution.Domain.Events.InventarioEstoqueEvents
{
    public class InventarioEstoqueUpdatedEvent : Event
    {
        public InventarioEstoqueUpdatedEvent(Guid id, string motivo)
        {
            Id = id;
            Motivo = motivo;
            AggregateId = id;

        }

        public Guid Id{ get; set; }

        public string Motivo { get; private set; }

    }
}
