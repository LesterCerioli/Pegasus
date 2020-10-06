using GalaxSolution.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using NetDevPack.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxSolution.Infrastructure.Data.Context.LocalStorage
{
    public class GalaxSolutionLocalStorageDbContext : DbContext, ILocalStorageUnitOfWork
    {
        private readonly IMediatorHandler _mediatorHandler;

        public GalaxSolutionLocalStorageDbContext(DbContextOptions<GalaxSolutionLocalStorageDbContext> options, IMediatorHandler mediatorHandler) : base(options)
        {
            _mediatorHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;

        }

        public internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        internal void Dispose()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            throw new NotImplementedException();
        }

        public DbSet<LocalStorage> LocalStorages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<Event>();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                gg => gg.GetProperties().Where(ggg => ggg.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfiguration(new LocalStorageConfiguration());

            base.OnModelCreating(modelBuilder);

        }
        public async Task<bool> Commit()
        {
            await _mediatorHandler.PublishDomainEvents(this).ConfigureAwait(false);

            var success = await SaveChangesAsync() > 0;

            return success;

        }

        Task<bool> IUnitOfWork.Commit()
        {
            throw new NotImplementedException();
        }

        void ILocalStorageUnitOfWork.Commit()
        {
            throw new NotImplementedException();
        }
    }

    public static class MediatorExtension
    {
        public static async Task PublishDomainEvents<T>(this IMediatorHandler mediator, T ctx) where T : DbContext
        {
            var domainEntities = ctx.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any());


            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.DomainEvents)
                .ToList();
            domainEntities.ToList()
                .ForEach(entity => entity.Entity.ClearDomainEvents());

            var tasks = domainEvents
                .Select(async (domainEvent) =>
                {
                    await mediator.PublishEvent(domainEvent);
                });

            await Task.WhenAll(tasks);

        }
    }
}
