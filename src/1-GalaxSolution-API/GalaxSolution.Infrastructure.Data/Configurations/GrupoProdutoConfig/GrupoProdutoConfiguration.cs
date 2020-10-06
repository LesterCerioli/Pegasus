using Galax.Solution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.Infrastructure.Data.Configurations.GrupoProdutoConfig
{
    public class GrupoProdutoConfiguration : IEntityTypeConfiguration<ProductGroup>
    {
           

        public void Configure(EntityTypeBuilder<ProductGroup> builder)
        {
            
            builder.Property(g => g.Id)
                .HasColumnName("id");

            builder.Property(g => g.Nome)
                    .HasColumnType("varchar(100)")
                    .HasMaxLength(100)
                    .IsRequired();

            
        }
    }
}
