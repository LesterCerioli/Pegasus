using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class StockUser : Entity, IAggregateRoot
    {


        public StockUser(Guid id, string login, string password, string name, string middleName, string lastName, string email )
        {
            Id = id;
            Login = login;
            Password = password;
            Name = name;
            MiddleName = middleName;
            LastName = lastName;
            Email = email;
        }
        
        protected StockUser() { }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public IList<StockProfile> Stockprofiles { get; private set; }
        public IList<CPF> CPFs {get; private set;}


        
    }
}
