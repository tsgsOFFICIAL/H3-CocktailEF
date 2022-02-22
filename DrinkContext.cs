using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEF
{
    internal class DrinkContext : DbContext
    {
        public DrinkContext() : base(nameOrConnectionString: @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;")
        {

        }

        public DbSet<Drink>? Drinks { get; set; }
    }
}
