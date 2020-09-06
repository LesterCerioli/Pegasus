using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PegasusSolution.Domain.ValueObject.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Infrastructure.Configuration
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            throw new NotImplementedException();
        }
    }
}
