using System;
using System.Collections.Generic;

#nullable disable

namespace com.farmcentral.be.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string FarmerId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductType { get; set; }

        public virtual Farmer Farmer { get; set; }
    }
}
