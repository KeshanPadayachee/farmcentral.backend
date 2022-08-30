using System;
using System.Collections.Generic;

#nullable disable

namespace com.farmcentral.be.Models
{
    public partial class Farmer
    {
        public Farmer()
        {
            Products = new HashSet<Product>();
        }

        public string FarmerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
