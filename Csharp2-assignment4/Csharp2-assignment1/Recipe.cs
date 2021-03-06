﻿/// Recipe.cs
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
        private List<string> ingredientsList = new List<string>();

        public string RecipeName { get; set; }

         public List<string> Ingredients => ingredientsList;

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
            ingredientsList.Add(item);
        }

        /// <summary>
        /// Get the ingredient at specified index from ingredientList
        /// </summary>
        public string GetIngredientAt(int index)
        {
            return (ingredientsList[index]);
        }

        /// <summary>
        /// change ingredient text at specified index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void ChangeIngredientAt(int index, string value)
        {
            ingredientsList[index] = value;
        }

        /// <summary>
        /// remove the ingredient from ingredientList
        /// </summary>
        public void DeleteIngredientAt(int index)
        {
            ingredientsList.RemoveAt(index);
        }

        public override string ToString()
        {
            var ingredients = string.Join(", ", ToStringArray());
            return RecipeName + ": " + ingredients + ".";
        }

        /// <summary>
        /// return ingredients list as string array
        /// </summary>
        public string[] ToStringArray()
        {
            List<string> strings = new List<string>();
            foreach (var item in ingredientsList)
            {
                strings.Add(item);
            }
            return strings.ToArray();
        }
    }
}
