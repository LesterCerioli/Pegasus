using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.UsuarioEstoqueEvents
{
    public class UsuarioEstoqueRemovedEvent : Event
    {
        public UsuarioEstoqueRemovedEvent(Guid id) 
        {
            Id = id;
            AggregateId = id;

        }
        public Guid Id { get; set; }
    }
}
