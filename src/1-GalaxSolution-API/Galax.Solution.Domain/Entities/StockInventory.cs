using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class StockInventory : Entity, IAggregateRoot
    {
        public StockInventory(Guid id, DateTime date, string motivation, int stockQty, int inventoryQty)
        {
            Id = id;
            Date = date;
            Motivation = motivation;
            StockQty = stockQty;
            InventoryQty = inventoryQty;
        }
        protected StockInventory() { }
        public DateTime Date { get; private set; }
        public string Motivation { get; private set; }
        public int StockQty{ get; private set; }
        public int InventoryQty { get; private set; }
        public Product Product { get; private set; }
        



        
    }
}
