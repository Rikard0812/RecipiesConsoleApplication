using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesConsoleApp.Models
{
    public class Ingredient
    {
        public Ingredient()
        {
            Recipies = new List<Recipe>();
        }
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public int? CaloriesPer100Gram { get; set; } // nullable
        public double Amount { get; set; }
        public AmountType AmountType { get; set; }
        public ICollection<Recipe> Recipies { get; set; }
    }
}
