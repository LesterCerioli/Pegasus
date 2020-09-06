using Microsoft.EntityFrameworkCore;
using PegasusSolution.Domain.Entities;
using PegasusSolution.Domain.ValueObject.Payments;
using PegasusSolution.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Infrastructure.Context.Context1
{
    public class PegasusDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestItem> RequestItems { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }

        public PegasusDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Mapping classes
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RequestConfiguration());
            modelBuilder.ApplyConfiguration(new RequestItemConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());

            modelBuilder.Entity<PaymentMethod>().HasData(
                new PaymentMethod()
                {
                    Id = 1,
                    Name = "Bankslip",
                    Description = "Payment Method Bankslip"
                },

                new PaymentMethod()
                {
                    Id = 2,
                    Name = "Credit Card",
                    Description = "Payment Method Credit Card"
                }
                );

            base.OnModelCreating(modelBuilder);





        }

    }
}
