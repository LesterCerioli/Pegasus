using Galax.Solution.Domain.Interfaces;
using GalaxSolution.Infrastructure.Data.Context.CidadeContext;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GalaxSolution.Infrastructure.Data.Repository.Repositories.Cidade
{
    public class CidadeRepository : ICityRepository
    {


        protected readonly GalaxSolutionCidadeDbContext CidadeDb;
        protected readonly DbSet<Cidade> DbSet;
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public void Add(Galax.Solution.Domain.Entities.City cidade)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Galax.Solution.Domain.Entities.City>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Galax.Solution.Domain.Entities.City> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Galax.Solution.Domain.Entities.City> GetByNome(string Nome)
        {
            throw new NotImplementedException();
        }

        public void Remove(Galax.Solution.Domain.Entities.City cidade)
        {
            throw new NotImplementedException();
        }

        public void Update(Galax.Solution.Domain.Entities.City cidade)
        {
            throw new NotImplementedException();
        }
    }
}
