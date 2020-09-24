using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Infrastructure.Context.Context1
{
    public class RegUserDbContext : DbContext, IUnitOfWork
    {
        private readonly IMediatorHandler mediatorHandler;
        public RegUserDbContext(DbContextOptions<RegUserDbContext> options, IMediatorHandler mediatorHandler) : base(options)
        {
            _mediatorHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<RegUser> RegUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
