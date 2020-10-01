using Galax.Solution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.Infrastructure.Data.Configurations.CNPJConfig
{
    public class CNPJConfiguration : IEntityTypeConfiguration<CNPJ>
    {
        public void Configure(EntityTypeBuilder<CNPJ> builder)
        {
            builder.Property(b => b.Id)
                .HasColumnName("id");

            builder.Property(b => b.NumCNPJ)
                .HasColumnType("varchar(20)")
                .HasMaxLength(100)
                .IsRequired();

        }
    }
}
