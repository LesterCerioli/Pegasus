using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using GalaxSolution.Infrastructure.Data.Configurations.FornecedorConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NetDevPack.Data;
using NetDevPack.Domain;
using NetDevPack.Mediator;
using NetDevPack.Messaging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GalaxSolution.Infrastructure.Data.Context.FornecedorContext
{
    public class GalaxSolutionFornecedorDbContext : DbContext, IUnitOfWork
    {

        private readonly IMediatorHandler _mediatorHandler;

        public GalaxSolutionFornecedorDbContext(DbContextOptions<GalaxSolutionFornecedorDbContext> options, IMediatorHandler mediatorHandler) : base(options)
        {
            _mediatorHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;

        }

<<<<<<< HEAD
        public DbSet<Provider> Fornecedores { get; set; }
=======
        public DbSet<Fornecedor> Fornecedores { get; set; }
>>>>>>> master

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<Event>();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                ff => ff.GetProperties().Where(fff => fff.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfiguration(new FornecedorConfiguration());

            base.OnModelCreating(modelBuilder);

        }

        public async  Task<bool> Commit()
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
