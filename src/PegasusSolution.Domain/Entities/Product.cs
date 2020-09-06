using System;
using System.Collections.Generic;
using System.Text;

namespace PegasusSolution.Domain.Entities
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public string FileName { get; set; }


        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                AddCritical("Critical - Product name was not informed!!");

            if (string.IsNullOrEmpty(Description))
                AddCritical("Critical - Product description was not informed!!");
        }
    }
}
