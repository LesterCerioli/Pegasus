using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Discount : Entity, IAggregateRoot
    {
        
        public Discount(decimal amount, DateTime expireDate)
        {
            Amount = amount;
            ExpireDate = expireDate;
        }

        protected Discount() { }
        public decimal Amount { get; private set; }
        public DateTime ExpireDate { get; set; }

        public bool IsValid()
        {
            return DateTime.Compare(DateTime.Now, ExpireDate) < 0;
        }

        public decimal Value()
        {
            if (IsValid())
                return Amount;
            else
                return 0;
        }

    }
}
