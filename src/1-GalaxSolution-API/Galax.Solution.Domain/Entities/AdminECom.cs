using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;


namespace Galax.Solution.Domain.Entities
{
    public class AdminECom : Entity, IAggregateRoot
    {
        
        private IList<Subscription> _subscription;
        
        public AdminECom(string firstName, string middlename, string lastName, string email)
        {
            FirstName = firstName;
            Middlename = middlename;
            LastName = lastName;
            Email = email;
            _subscription = new List<Subscription>();
        }

        public string FirstName { get; private set; }
        public string Middlename { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }

        public void AddSubscription(Subscription sibscription)
        {
            var hasSubscriptionActive = false;
            foreach (var sub in _subscription)
            {
                if (sub.Actived)
                    hasSubscriptionActive = true;
            }

            AddNotifications(new Contract()
                .Requires()
                .Isfalse(hasSubscriptionActive, "AdminECom.Subscription", "You have an actived subscription")
                .AreNotEquals(0, Subscription.payments.Count, "AdminECom.Subscription.Payments", "This subscription hasn't payment")
            );

            if (Valid)
                _subscription.Add(subscription);

        }
        
    }
}