using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class ProductOutput : Entity, IAggregateRoot
    {

        public ProductOutput(Guid id, string number, DateTime date, int quantity)
        {
            Id = id;
            Number = number;
            Date = date;
            Quantity = quantity;
        }
        
        public ProductOutput() { }
        public string Number { get; private set; }
        public DateTime Date { get; private set; }
        public int Quantity { get; private set; }
        public IList<Product> Products { get; private set; }


        
    }
}
