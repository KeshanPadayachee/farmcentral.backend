using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using com.farmcentral.be.Models;

namespace com.farmcentral.be.Data
{
    public class comfarmcentralbeContext : DbContext
    {
        public comfarmcentralbeContext (DbContextOptions<comfarmcentralbeContext> options)
            : base(options)
        {
        }

        public DbSet<com.farmcentral.be.Models.Employee> Employee { get; set; }

        public DbSet<com.farmcentral.be.Models.Farmer> Farmer { get; set; }

        public DbSet<com.farmcentral.be.Models.Product> Product { get; set; }
    }
}
