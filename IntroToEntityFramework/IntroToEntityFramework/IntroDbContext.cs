using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEntityFramework
{
    public class IntroDbContext : DbContext // inheriting from DbContext
    {
        public IntroDbContext() : base() // inheriting the parent constructors. inside base("name=ConnectionStringName") ApConfig connectionStrings
        {

        }

        public virtual DbSet<Customer> Customers { get; set; } 
        public virtual DbSet<Order> Orders { get; set; }

    }
}
