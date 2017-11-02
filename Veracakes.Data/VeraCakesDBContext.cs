using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Veracakes.Data
{
    public class VeraCakesDBContext : DbContext
    {
        public VeraCakesDBContext() : base("name=CakeOrderTrackingDB") { }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PastryDesign> PastryDesigns { get; set; }

    }
}
