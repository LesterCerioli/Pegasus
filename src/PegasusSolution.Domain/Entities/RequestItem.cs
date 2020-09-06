using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Domain.Entities
{
    public class RequestItem : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public override void Validate()
        {
            if (ProductId == 0)
                AddCritical("Product reference not identified");

            if (Amount == 0)
                AddCritical("Amount wasn`t informed!!");
        }

        internal static bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
