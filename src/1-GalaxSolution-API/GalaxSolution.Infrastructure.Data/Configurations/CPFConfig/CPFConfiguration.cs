using Galax.Solution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.Infrastructure.Data.Configurations.CPFConfig
{
    public class CPFConfiguration : IEntityTypeConfiguration<CPF>
    {
        public void Configure(EntityTypeBuilder<CPF> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("id");

            builder.Property(c => c.NumCPF)
                .HasColumnType("varchar(20)")
                .HasMaxLength(25)
                .IsRequired();

        }
    }
}
