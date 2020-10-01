using Galax.Solution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using NetDevPack.Mediator;
using System;
using System.Threading.Tasks;
using GalaxSolution.Infrastructure.Data.Configurations.CNPJConfig;
using FluentValidation.Results;
using NetDevPack.Messaging;
using System.Linq;
using GalaxSolution.Infrastructure.Data.Context.CidadeContext;
using NetDevPack.Domain;

namespace GalaxSolution.Infrastructure.Data.Context.CNPJContext
{
    public class GalaxSolutionCNPJDbContext : DbContext, IUnitOfWork
    {

        private readonly IMediatorHandler _mediatorHandler;


        public GalaxSolutionCNPJDbContext(DbContextOptions<GalaxSolutionCNPJDbContext> options, IMediatorHandler mediatorHandler) : base(options)
        {
            _mediatorHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
                

        public DbSet<CNPJ> CNPJs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<Event>();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                bb => bb.GetProperties().Where(bbb => bbb.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)"); 
            
            
            modelBuilder.ApplyConfiguration(new CNPJConfiguration());

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
