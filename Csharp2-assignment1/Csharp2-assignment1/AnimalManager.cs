/// AnimalManager.cs
/// Ann-Marie Bergström  ai2436 2018-02-13

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment1
{
    /// <summary>
    /// Handles animal list
    /// </summary>
    class AnimalManager
    {
        private List<Animal> animalList; //declare list of animalList

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnimalManager()
        {
            animalList = new List<Animal>(); //create list of animalList
        }


        #region Properties

        /// <summary>
        /// Data to fill a ListView, one animal per item in the list.
        /// </summary>
        public IEnumerable<string[]> AnimalsAsRows => animalList.Select(animal => animal.RowStrings).ToList();

        #endregion
         
        /// <summary>
        /// Add animal to list
        /// </summary>
        /// <param name="animal"></param>
        internal void AddAnimal(Animal animal)
        {
            animalList.Add(animal);
        }
    }
}

