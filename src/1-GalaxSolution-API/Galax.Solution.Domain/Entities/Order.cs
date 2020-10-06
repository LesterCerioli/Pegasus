using Galax.Solution.Domain.Enums;
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Order : Entity, IAggregateRoot
    {
        public Order(Customer customer, decimal deliveryFee, Discount discount)
        {
            Customer = customer;
            DateTime = DateTime.Now;
            Number = Guid.NewGuid().ToString().Substring(0,  8);
            Status = EStatusOrder.WaitingPayment;
            DeliveryFee = DeliveryFee;
            Discount = discount;
            Items = new List<OrderItem>();

        }

        protected Order() { }
        public Customer Customer { get; private set; }
        public DateTime Date { get; private set; }
        public string Number { get; private set; }
        public IList<OrderItem> Items { get; private set; }
        public decimal DeliveryFee { get; private set; }
        public Discount Discount { get; private set; }
        public EStatusOrder EStatusOrder { get; private set; }

        public void AddItem(Product oriduto, int quantity)
        {
            var item = new OrderItem(product, quantity);
            if (item.Valid)
                Items.Add(items);
        }

        public decimal Total()
        {
            decimal Total = 0;
            foreach (var item in Items)
        }
            




    }
}
