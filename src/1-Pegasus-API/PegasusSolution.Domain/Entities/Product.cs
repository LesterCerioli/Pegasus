using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Domain.Entities
{
    public class Product : Entity, IAggregateRoot
    {
        public Product(Guid id, string name, string description, decimal price, string fileName)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            FileName = fileName;
        }

        protected Product() { }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string FileName { get; set; }
    }
}
