using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using NetDevPack.Mediator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GalaxSolution.Infrastructure.Data.Context.Produto
{
    public class GalaxSolutionProdutoDbContext : DbContext, IUnitOfWork
    {
        private readonly IMediatorHandler _mediatorHandler;


        public GalaxSolutionProdutoDbContext(DbContextOptions<GalaxSolutionProdutoDbContext> options, IMediatorHandler mediatorHandler) : base(options)
        {
            _mediatorHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Produto> Produtos { get; set; }


        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
        }
    }
}
