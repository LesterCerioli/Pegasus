using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IGrupoProdutoRepository : IRepository<GrupoProduto>
    {
        Task<GrupoProduto> GetById(Guid id);
        Task<GrupoProduto> GetByNome(string nome);
        Task<IEnumerable<GrupoProduto>> GetAll();

        void Add(GrupoProduto grupoProduto);
        void Update(GrupoProduto grupoProduto);
        void Remove(GrupoProduto grupoProduto);
        
        
    }
}
