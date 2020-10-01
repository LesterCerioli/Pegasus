using Galax.Solution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.Infrastructure.Data.Configurations.InvantarioEstoqueConfig
{
    public class InventarioEstoqueConfiguration : IEntityTypeConfiguration<InventarioEstoque>
    {
       

        public void Configure(EntityTypeBuilder<InventarioEstoque> builder)
        {
            builder.Property(h => h.Id)
                .HasColumnName("id");

            builder.Property(h => h.Data)
                .HasColumnType("varchar(100")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(h => h.Motivo)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(h => h.QtdEstoque)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(h => h.QuantidadeInventario)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();


        }
    }
}
