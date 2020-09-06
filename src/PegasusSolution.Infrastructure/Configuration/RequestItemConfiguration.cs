using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PegasusSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Infrastructure.Configuration
{
    public class RequestItemConfiguration : IEntityTypeConfiguration<RequestItem>
    {
        public void Configure(EntityTypeBuilder<RequestItem> builder)
        {
            throw new NotImplementedException();
        }
    }
}
