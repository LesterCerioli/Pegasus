using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
       

    public class Product : Entity, IAggregateRoot
    {
        
        public Product(Guid id, string name, string code,
            decimal priceCost, decimal priceSale, int stockQuantity, bool actived, string image, MeasurementUnit measurementUnit, ProductGroup productGroup)
        {
            Id = id;
            Name = name;
            Code = code;
            PriceCost = priceCost;
            PriceSale = priceSale;
            StockQuantity = stockQuantity;
            Actived = actived;
            Image = image;
            MeasurementUnit = measurementUnit;
            ProductGroup = productGroup;
            
            
            
        }
        
        protected Product() { }
        
        public string Code { get; private set; }
        public string Name { get; private set; }

        public decimal PriceCost { get; private set; }
        public decimal PriceSale { get; private set; }
        public int StockQuantity { get; private set; }
        public MeasurementUnit MeasurementUnit { get; private set; }
        
        public ProductGroup ProductGroup { get; private set; }
        
        public ProductBrand ProductBrand { get; private set; }
        public Provider Provider { get; private set; }
        public LocalStorage StorageLocal { get; private set; }
        public bool Actived { get; set; }
        public string Image { get; set; }



        
    }
}
