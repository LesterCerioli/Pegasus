using NetDevPack.Data;
using PegasusSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PegasusSolution.Domain.Interfaces
{
    public interface IRequestRepository : IRepository<Request>
    {
        Task<Request> GetById(Guid id);
        Task<Request> GetByNumber(int number);
        Task<IEnumerable<Request>> GetAll();

        void Add(Request request);
        void Update(Request request);
        void Remove(Request request);
    }
}
