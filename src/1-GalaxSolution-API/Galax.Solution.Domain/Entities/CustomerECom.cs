using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;


namespace Galax.Solution.Domain.Entities
{
    public class CustomerECom : Entity, IAggregateRoot
    {
        public CustomerECom(string firstName, string middlename, string lastName, string email)
        {
            FirstName = firstName;
            Middlename = middlename;
            LastName = lastName;
            Email = email;
        }

        public string FirstName { get; private set; }
        public string Middlename { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}