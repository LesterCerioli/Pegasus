using NetDevPack.Data;
using PegasusSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PegasusSolution.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetById(Guid id);
        Task<User> GetByEmail(string email);
        Task<IEnumerable<User>> GetAll();

        void Add(User user);
        void Update(User user);
        void Remove(User user);
    }
}
