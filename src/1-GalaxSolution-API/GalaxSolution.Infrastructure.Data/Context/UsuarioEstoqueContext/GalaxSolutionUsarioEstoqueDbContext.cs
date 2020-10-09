using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using GalaxSolution.Infrastructure.Data.Configurations.UsuarioEstoqueConfig;
using GalaxSolution.Infrastructure.Data.Context.UsuarioEstoqueContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NetDevPack.Data;
using NetDevPack.Domain;
using NetDevPack.Mediator;
using System;
using NetDevPack.Messaging;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxSolution.Infrastructure.Data.Context.UsuarioEstoqueContext
{
    public sealed class GalaxSolutionUsarioDbContext : DbContext, IUnitOfWork
    {
        
        //Context file that will be imported to database
        private readonly IMediatorHandler _mediatorHandler;

        public GalaxSolutionUsarioDbContext(DbContextOptions<GalaxSolutionUsarioDbContext> options, IMediatorHandler mediatorHandler) : base(options)
        {
            _mediatorHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

<<<<<<< HEAD
        public DbSet<StockUser> UsuariosEstoque { get; set; }
=======
        public DbSet<UsuarioEstoque> UsuariosEstoque { get; set; }
>>>>>>> master



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<Event>();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                pp => pp.GetProperties().Where(ppp => ppp.ClrType == typeof(string))))
                property.SetColumnType("Varchar(100)");


            modelBuilder.ApplyConfiguration(new UsuarioEstoqueConfiguration());

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

        public static async Task PublishDomainEvents<T>(this IMediatorHandler  mediator, T ctx) where T : DbContext
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
