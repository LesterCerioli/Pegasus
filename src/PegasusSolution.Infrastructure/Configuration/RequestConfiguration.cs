using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PegasusSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Infrastructure.Configuration
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            throw new NotImplementedException();
        }
    }
}
