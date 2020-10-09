﻿using Galax.Solution.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.Infrastructure.Data.Configurations.EstadoConfig
{
<<<<<<< HEAD
    public class EstadoConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
=======
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
>>>>>>> master
        {
            builder.Property(e => e.Id)
                .HasColumnType("id");

            builder.Property(e => e.Nome)
                .HasColumnType("varchar100")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.UF)
                .HasColumnType("varchar(100)")
                .IsRequired();

        }
    }
}
