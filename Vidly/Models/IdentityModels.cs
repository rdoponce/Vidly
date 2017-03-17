using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class IdentityModels : DbContext
    {
        public DbSet<Customer> Customers {get; set;}

        public IdentityModels()
            : base("Vidly.Models.IdentityModels")
        {
        }

        public static DbContext Create()
        {
            return new IdentityModels();
        }
    }
}