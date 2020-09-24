using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Domain.Entities
{
    
    
    public class Request : Entity, IAggregateRoot
    {
        public Request(Guid id, DateTime requestDate, DateTime deliveryPrevisiousDate, string postalCode, string state, string city, string fullAddress, string district, string country, int number)
        {
            Id = id;
            Number = number;
            RequestDate = requestDate;
            DeliveryPrevisiousDate = deliveryPrevisiousDate;
            PostalCode = postalCode;
            State = state;
            City = city;
            FullAddress = fullAddress;
            District = district;
            Country = country;
        }
        protected Request() { }
        public int Number { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime DeliveryPrevisiousDate { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string FullAddress { get; set; }
        public string District { get; set; }
        public string Country { get; set; }

    }
    

    







}
    
    
    