/// Recipe.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    public class Recipe
    {
        private IListManager<string> ingredientsList = new ListManager<string>();

        public string RecipeName { get; internal set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Recipe()
        {

        }

        /// <summary>
        /// add the ingredient to ingredientList
        /// </summary>
        public void AddIngredient(string item)
        {
            ingredientsList.AddItem(item);
        }

        /// <summary>
        /// Get the ingredient at specified index from ingredientList
        /// </summary>
        public string GetIngredientAt(int index)
        {
            return (ingredientsList.GetItem(index));
        }

        /// <summary>
        /// change ingredient text at specified index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public void ChangeIngredientAt(int index, string value)
        {
            ingredientsList.ChangeItem(index, value);
        }

        /// <summary>
        /// remove the ingredient from ingredientList
        /// </summary>
        public void DeleteIngredientAt(int index)
        {
            ingredientsList.RemoveItem(index);
        }

        public override string ToString()
        {
            var ingredients = string.Join(", ", ingredientsList.ToStringList());
            return RecipeName + ": " + ingredients + ".";
        }

        /// <summary>
        /// return ingredients list as string array
        /// </summary>
        public string[] ToStringArray()
        {
            return ingredientsList.ToStringArray();
        }
    }
}
