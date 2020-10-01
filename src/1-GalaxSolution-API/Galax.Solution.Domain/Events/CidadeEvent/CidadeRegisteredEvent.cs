using Galax.Solution.Domain.Entities;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.CidadeEvent
{
    public class CidadeRegisteredEvent : Event
    {
        public CidadeRegisteredEvent(Guid id, string nome, bool ativo)
        {
            Id = id;
            Nome = nome;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        public string Nome { get; private set; }
       
    }
}
