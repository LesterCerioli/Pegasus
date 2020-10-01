using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.UnidadeMedidaEvents
{
    public class UnidadeMedidaUpdatedEvent : Event
    {
        public UnidadeMedidaUpdatedEvent(Guid id, string nome, string sigla, bool ativo) 
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
            Ativo = ativo;
            AggregateId = id;


        }

        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public string Sigla { get; private set; }
        public bool Ativo { get; private set; }
        
        
    }
}
