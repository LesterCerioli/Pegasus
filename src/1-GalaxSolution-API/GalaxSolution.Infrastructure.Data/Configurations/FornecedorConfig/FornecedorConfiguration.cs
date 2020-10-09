using Galax.Solution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.Infrastructure.Data.Configurations.FornecedorConfig
{
<<<<<<< HEAD
    public class FornecedorConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
=======
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
>>>>>>> master
        {
            builder.Property(f => f.Id)
                .HasColumnName("id");

            builder.Property(f => f.NomeFantasia)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(f => f.RazaoSocial)
                .HasColumnType("varchar(1000)")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(f => f.Telefone)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.Contato)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(f => f.Logradouro)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(f => f.Numero)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.Complemento)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.Cep)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
