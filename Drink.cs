using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEF
{
    /// <summary>
    /// A Drink is an alcoholic beverage.
    /// <br></br>Designed &amp; intended for adults only 🔞
    /// </summary>
    internal class Drink
    {
        /// <summary>
        /// The id for the database
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the drink
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// A short description of the drink
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// The recipe for the drink
        /// </summary>
        public Recipe Recipe { get; private set; }
        /// <summary>
        /// Constructor for the drink class 🔞
        /// </summary>
        /// <param name="name">The name of the drink</param>
        /// <param name="description">The description of the drink</param>
        /// <param name="recipe">The recipe for the drink</param>
        public Drink(string name, string description, Recipe recipe)
        {
            Name = name;
            Description = description;
            Recipe = recipe;
        }
    }
}
