using NetDevPack.Domain;
using System;


namespace PegasusSolution.Domain.Entities
{
    public class User : Entity, IAggregateRoot
    {
        public User(Guid id, string email, string password, string name, string lastName, bool administrator)
        {
            Id = id;
            Email = email;
            Password = password;
            Name = name;
            LastName = lastName;
            Administrator = administrator;
        }

        protected User() { }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Administrator { get; set; }
    }
}
