using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;



namespace Galax.Solution.Domain.Entities
{
    public class Subscription : Entity, IAggregateRoot
    {
        
        private IList<Payment> _payments {get; private set;}
        public Subscription(DateTime createDate, dateTime lastUpdatedate, DateTime? expireDate, bool actived, IReadOnlyCollection<Payment> payments)
        {
            CreateDate = createDate;
            LastUpdatedate = lastUpdatedate;
            ExpireDate = expireDate;
            Actived = actived;
            _payment = new List<Payment>();
        }

        public DateTime CreateDate {get; private set;}
        public dateTime LastUpdatedate {get; private set;}
        public DateTime? ExpireDate {get; private set;}
        public bool Actived {get; private set;}
        public IReadOnlyCollection<Payment> Payments {get; private set;}

        public void AddPayment(Payment payment)
        {
            AddNothification(new Contract()
                .Requires()
                .IsGreaterThan(DateTime.Now, payment.Paiddate, "Subscription.Payments", "payment date must be future")
            
            );
            _payments.Add(payment);

        }

        public void Actived()
        {
            Actived = true;
            LastUpdatedate = DateTime.Now;
        }

        public void Inactivate()
        {
            Activated = false;
            LastUpdatedate = DateTime.Now;
        }
        
    }
}