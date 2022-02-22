using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CocktailEF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient("rom", 250));
            ingredients.Add(new Ingredient("cola", 250));

            Recipe recipe = new Recipe(ingredients);

            using (DrinkContext ctx = new DrinkContext())
            {
                var drinks = ctx.Drinks;
                //var drinks = (from d in ctx.Drinks
                //                orderby d.Name
                //                select d).ToList<Drink>();


                /*
                Drink drink = new Drink("Rom & Cola", "Simple drink, 50/50 rom & coke", recipe);

                ctx.Drinks.Add(drink);
                ctx.SaveChanges();
                */
            }

        }
        #region Drinks events
        private void DrinksListBoxKeyDown(object sender, KeyEventArgs e)
        {

        }
        private void DrinksListBoxMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void DrinksSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DrinksTextBoxKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ClearDrinksList(object sender, RoutedEventArgs e)
        {

        }

        private void AddDrinkButton(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveDrinkButton(object sender, RoutedEventArgs e)
        {

        }
        #endregion
        #region Ingredients events
        private void IngredientsListBoxKeyDown(object sender, KeyEventArgs e)
        {

        }
        private void IngredientsListBoxMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void IngredientsSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void IngredientsTextBoxKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ClearIngredientsList(object sender, RoutedEventArgs e)
        {

        }

        private void AddIngredientButton(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveIngredientButton(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        private void SaveToDbButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
