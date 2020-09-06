using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Domain.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Administrator { get; set; }

        public virtual ICollection<Request> Requests { get; set; }

        protected override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AddCritical("Email must be informed!!");

            if (string.IsNullOrEmpty(Password))
                AddCritical("Password must be informed!!");

        }
    }
}
