using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using GalaxSolution.Infrastructure.Data.Configurations.InvantarioEstoqueConfig;
using GalaxSolution.Infrastructure.Data.Context.CidadeContext;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using NetDevPack.Domain;
using NetDevPack.Mediator;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxSolution.Infrastructure.Data.Context.InvantarioEstoqueContext
{
    public class GalaxSolutionInventarioEstoqueDbContext : DbContext, IUnitOfWork
    {

        private readonly IMediatorHandler _mediatorHandler;

        public GalaxSolutionInventarioEstoqueDbContext(DbContextOptions<GalaxSolutionInventarioEstoqueDbContext> options, IMediatorHandler mediatorHandler) : base(options)
        {
            _mediatorHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;

        }

        public DbSet<InventarioEstoque> InventáriosEstoque { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<Event>();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                gg => gg.GetProperties().Where(ggg => ggg.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfiguration(new InventarioEstoqueConfiguration());

            base.OnModelCreating(modelBuilder);

        }
        public async Task<bool> Commit()
        {
            await _mediatorHandler.PublishDomainEvents(this).ConfigureAwait(false);

            var success = await SaveChangesAsync() > 0;

            return success;

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
