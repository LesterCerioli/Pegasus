using Galax.Solution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.Infrastructure.Data.Configurations.UsuarioEstoqueConfig
{
<<<<<<< HEAD
    public class UsuarioEstoqueConfiguration : IEntityTypeConfiguration<StockUser>
    {
        public void Configure(EntityTypeBuilder<StockUser>builder)
=======
    public class UsuarioEstoqueConfiguration : IEntityTypeConfiguration<UsuarioEstoque>
    {
        public void Configure(EntityTypeBuilder<UsuarioEstoque>builder)
>>>>>>> master
        {
            builder.Property(p => p.Id)
                .HasColumnName("Id");

            builder.Property(p => p.Login)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(p => p.Senha)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();



            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(P => P.NomeMeio)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(P => P.Sobrenome)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(p => p.Email)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();


<<<<<<< HEAD
            builder.Property(p => p.Telefone)
                .HasColumnType("varchar(15)")
                .HasMaxLength(15)
                .IsRequired();


=======
>>>>>>> master

        }
    }
}
