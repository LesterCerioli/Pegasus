
using PegasusSolution.Domain.ValueObject.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Domain.Entities
{
    public class Request : Entity
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public int UserId { get; set; }
        public virtual User Users { get; set; }
        public DateTime DeliveryPreviousDate { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string FullAddress { get; set; }
        public int AddressNumber { get; set; }
        public int PaymentMethodId { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual ICollection<RequestItem> RequestItems { get; set; }

        public override void Validate()
        {
            ClearValidationmessage();

            if (!RequestItem.Any())
                AddCritical("Critical - Request must contain request item");

            if (string.IsNullOrEmpty(PostalCode))
                AddCritical("Critical - Post Code must be informed!!");

            if (PaymentMethodId == 0)
                AddCritical("PaymentMethod was not informed!!");

            
        }
    }
}
