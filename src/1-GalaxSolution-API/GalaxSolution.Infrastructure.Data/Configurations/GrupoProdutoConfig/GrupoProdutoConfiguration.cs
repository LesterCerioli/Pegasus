using Galax.Solution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.Infrastructure.Data.Configurations.GrupoProdutoConfig
{
    public class GrupoProdutoConfiguration : IEntityTypeConfiguration<GrupoProduto>
    {
           

        public void Configure(EntityTypeBuilder<GrupoProduto> builder)
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
