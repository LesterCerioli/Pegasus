using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Domain.Entities
{
    public class RegUser : Entity, IAggregateRoot
    {
        public RegUser(Guid id, string login, string password, string name, string middleName, string lastName)
        {
            Id = id;
            Login = login;
            Password = password;
            Name = name;
            MiddleName = middleName;
            LastName = lastName;
        }

        protected RegUser() { }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Lastname { get; set; }
        
    }
}
