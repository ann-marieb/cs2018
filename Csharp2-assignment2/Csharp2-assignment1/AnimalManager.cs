/// AnimalManager.cs
/// Ann-Marie Bergström  ai2436 2018-02-13

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    /// <summary>
    /// Handles animal list
    /// </summary>
    public class AnimalManager
    {
        private List<IAnimal> animalList; //declare list of animalList

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnimalManager()
        {
            animalList = new List<IAnimal>(); //create list of animals 
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
        internal void AddAnimal(IAnimal animal)
        {
            animalList.Add(animal);
        }

        /// <summary>
        /// Check if index is valid.
        /// </summary>
        /// <param name="index"></param>
        public bool ValidateIndex(int index)
        {
            if (index < animalList.Count && index >= 0) return true; // TODO: vänd
            else return false;
        }

        /// <summary>
        /// Returns the animal at the given index in the list of animals.
        /// </summary>
        /// <param name="index">the animal at the given index in the list of animals</param>
        /// <returns></returns>
        public IAnimal GetAnimal(int index)
        {
            var animal = animalList[index]; //get animal from list
            var animalCopy = animal.Clone(); // clone animal
            return animalCopy; //return animal
        }
    }
}

