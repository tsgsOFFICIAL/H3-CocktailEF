using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEF
{
    /// <summary>
    /// The recipe, containing a list of ingredients
    /// </summary>
    internal class Recipe
    {
        /// <summary>
        /// The id for the database
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The list of ingredients.
        /// <br></br>Also known as the recipe.
        /// </summary>
        public List<Ingredient> Ingredients { get; private set; }
        /// <summary>
        /// The constructor for the recipe
        /// </summary>
        /// <param name="ingredients">The list of ingredients</param>
        public Recipe(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }
    }
}
