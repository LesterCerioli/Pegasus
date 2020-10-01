using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.EntradaProdutoEvents
{
    public class EntradaProdutoUpdatedEvent : Event
    {
        public EntradaProdutoUpdatedEvent(Guid id, string numero, DateTime data, int quantidade)
        {
            Id = id;
            Numero = numero;
            Data = data;
            Quantidade = quantidade;
            AggregateId = id;


        }

        public Guid Id { get; set; }
        public string Numero { get; private set; }
        public DateTime Data { get; private set; }
        public int Quantidade { get; private set; }


    }
}
