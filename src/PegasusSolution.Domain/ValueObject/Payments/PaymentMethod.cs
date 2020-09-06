using PegasusSolution.Domain.Listed.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Domain.ValueObject.Payments
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool EhBankslip
        {
            get { return Id == (int)PaymentMethodTypeEnum.Bankslip; }
        }

        public bool ECreditCard
        {
            get { return Id == (int)PaymentMethodTypeEnum.CreditCard; }
        }

        public bool EhNotIdentified
        {
            get { return Id == (int)PaymentMethodTypeEnum.NotIdentified; }
        }
            

    }
}
