using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Provider : Entity, IAggregateRoot
    {

        public Provider(Guid id, string fantasyName, string socialReason, string telephone, string contactName, string contactNumber, string address, string number, string complement, string postalCode, bool actived)
        {
            Id = id;
            FantasyName = fantasyName;
            SocialReason = socialReason;
            
            Telephone = telephone;
            ContactName = contactName;
            ContactNumber = contactNumber;
            Address = address;
            Number = number; 
            Complement = complement;
            PostalCode = postalCode;
            Actived = actived;
        }
               
        
        protected Provider() { }
        public string SocialReason { get; private set; }
        public string FantasyName { get; private set; }
        public Kind Kinds { get; private set; }
        public string Telephone { get; private set; }
        public string ContactName { get; private set; }
        public string ContactNumber { get; private set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string Complement { get; private set; }
        public string PostalCode { get; private set; }
        public IList<Country> Countries { get; private set; }
        public IList<State> States { get; private set; }
        public IList<City> Cities { get; private set; }
        public bool Actived { get; private set; }
        public CNPJ CNPJ {get; private set;}

                
    }
}
