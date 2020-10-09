using Galax.Solution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.Infrastructure.Data.Configurations.EntradaProdutoConfig
{
<<<<<<< HEAD
    public class EntradaProdutoConfiguration : IEntityTypeConfiguration<ProductInput>
    {
        public void Configure(EntityTypeBuilder<ProductInput> builder)
=======
    public class EntradaProdutoConfiguration : IEntityTypeConfiguration<EntradaProduto>
    {
        public void Configure(EntityTypeBuilder<EntradaProduto> builder)
>>>>>>> master
        {
            builder.Property(d => d.Id)
                .HasColumnName("id");


            builder.Property(d => d.Numero)
                .HasColumnType("varchar(50)")
                .HasMaxLength(100)
                .IsRequired();

            
            builder.Property(d => d.Data)
                .HasColumnType("varchar(50)")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(d => d.Quantidade)
                .HasColumnType("varchar(50)")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
