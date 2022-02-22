using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEF
{
    /// <summary>
    /// A Ingredient object will hold a name &amp; an amount.
    /// </summary>
    internal class Ingredient
    {
        /// <summary>
        /// The id for the database
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the ingredient
        /// </summary>
        public string? Name { get; private set; }
        /// <summary>
        /// The amount of the ingredient in milliliters (ml)
        /// </summary>
        public uint? Amount { get; private set; }
        /// <summary>
        /// Constructor for the Ingredient class
        /// </summary>
        /// <param name="name">The name of the ingredient</param>
        /// <param name="amount">The amount in milliliters (ml)</param>
        public Ingredient(string name, uint amount)
        {
            Name = name;
            Amount = amount;
        }
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Ingredient()
        {

        }
    }
}
