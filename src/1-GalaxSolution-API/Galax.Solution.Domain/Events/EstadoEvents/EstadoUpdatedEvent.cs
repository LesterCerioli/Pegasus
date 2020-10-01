using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.EstadoEvents
{
    public class EstadoUpdatedEvent : Event
    {
        public EstadoUpdatedEvent(Guid id, string nome, string uf, bool ativo) 
        {
            Id = id;
            Nome = nome;
            UF = uf;
            Ativo = ativo;
            AggregateId = id;

        }

        public Guid Id { get; set; }

        public string Nome { get; private set; }
        public string UF { get; private set; }
        public bool Ativo { get; private set; }


    }
}
