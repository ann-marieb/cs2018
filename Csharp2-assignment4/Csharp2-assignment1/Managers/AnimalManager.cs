/// AnimalManager.cs
/// Ann-Marie Bergström  ai2436 2018

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
    public class AnimalManager : ListManager<IAnimal>
    {
        private static int nextAnimalID = 100; //unique id for each animal
        //private List<IAnimal> animalList; //declare list of animalList

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnimalManager() : base ()
        {
            //animalList = new List<IAnimal>(); //create list of animals 
        }

        #region Properties
        /// <summary>
        /// Data to fill a ListView, one animal per item in the list.
        /// </summary>
        public IEnumerable<string[]> AnimalsAsRows => this.Select(animal => animal.RowStrings).ToList();
        #endregion

        #region Methods

        /// <summary>
        /// Create animal ID
        /// </summary>
        /// <returns>animal ID</returns>
        private static int NewId()
        {
            return nextAnimalID++;
        }

        /// <summary>
        /// Add animal to list
        /// </summary>
        /// <param name="animalIn"></param>
        internal bool AddAnimal(IAnimal animalIn)
        {
            animalIn.AnimalID  = NewId();
            return AddItem(animalIn); //AddItem in ListManager
        }

        /// <summary>
        /// Returns the animal at the given index in the list of animals.
        /// </summary>
        /// <param name="index">the animal at the given index in the list of animals</param>
        /// <returns></returns>
        public IAnimal GetAnimal(int index)
        {
            var animal = GetItem(index); //get animal from itemlist
            var animalCopy = animal.CopyAnimal(); // copy animal
            return animalCopy; //return animal
        }

        //public void Sort(IComparer<IAnimal> comparer)
        //{
        //    animalList.Sort(comparer);
        //}
        #endregion
    }
}

