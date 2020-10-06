using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class OrderItem : Entity, IAggregateRoot
    {
        
        public OrderItem(Product produto, decimal precoVenda, int quantity)
        {
            Product = Product;
            PriceSale = Product != null ? product.PriceSale : 0;
            Quantity = quantity;
        }
        protected OrderItem() { }
        public Product Product { get; private set; }
        public decimal PriceSale { get; private set; }
        public int Quantity { get; private set; }

        public decimal Total()
        {
            return PriceSale * Quantity;
        }

    }

    

}
