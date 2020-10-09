using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.EntradaProdutoEvents
{
    public class ProductInputUpdatedEvent : Event
    {
        public ProductInputUpdatedEvent(Guid id, string numero, DateTime data, int quantidade)
        {
            Id = id;
            Number = number;
            Date = date;
            Amount = amount;
            AggregateId = id;


        }

        public Guid Id { get; set; }
        public string Number { get; private set; }
        public DateTime Date { get; private set; }
        public int Amount { get; private set; }


    }
}
