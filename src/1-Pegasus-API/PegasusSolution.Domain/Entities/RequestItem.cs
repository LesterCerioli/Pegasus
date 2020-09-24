using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Domain.Entities
{
    public class RequestItem : Entity, IAggregateRoot
    {
        public RequestItem(Guid id, int amount)
        {
            Id = id;
            Amount = amount;
            
        }

        protected RequestItem() { }
        public int Amount { get; set; }


    }
}
