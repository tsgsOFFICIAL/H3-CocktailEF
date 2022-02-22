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
        public DrinkContext() : base()
        {

        }

        public DbSet<Drink> Drinks { get; set; }
    }
}
