﻿/// Animal.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    public abstract class Animal : IAnimal
    {
        #region Fields
        private int animalID;
        private string name;
        private int ageInt;
        private string gender;
        protected FoodSchedule foodScheduleObj; //declare foodScheduleObj as type FoodSchedule
        protected string species;
        #endregion

        #region Constructors
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="animalID"></param>
        /// <param name="name"></param>
        /// <param name="ageInt"></param>
        /// <param name="gender"></param>
        public Animal(int animalID, string name, int ageInt, string gender)
        {
            this.animalID = animalID;
            this.name = name;
            this.ageInt = ageInt;
            this.gender = gender;
            this.species = GetType().Name.ToLower();
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        protected Animal(Animal other)
        {
            animalID = other.animalID;
            name = other.name;
            ageInt = other.ageInt;
            gender = other.gender;
            foodScheduleObj = other.foodScheduleObj;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The name of the animal
        /// </summary>
        public string Name
        {
            get => name;
        }

        /// <summary>
        /// The species of the animal
        /// </summary>
        public string Species
        {
            get => species;
        }

        /// <summary>
        /// The ID of the animal
        /// </summary>
        public int AnimalID
        {
            get => animalID;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Make a copy of the animal with the same ID number.
        /// </summary>
        public abstract IAnimal CopyAnimal();

        /// <summary>
        /// Returns the eater type of the animal.
        /// </summary>
        public abstract EaterType GetEaterType();

        /// <summary>
        /// Returns feedDescriptionList of the animal.
        /// </summary>
        public List<string> GetFoodSchedule()
        {
            var fList = foodScheduleObj.ToStringList(); // get feedDescriptionList from FoodSchedule
            return new List<string>(fList);
        }

        /// <summary>
        /// Returns the species of the animal.
        /// </summary>
        public string GetSpecies()
        {
            return GetType().Name;
        }

        /// <summary>
        /// Strings used to fill a row in a ListView.
        /// </summary>
        public string[] RowStrings => new[]
        {
            GetType().Name,
            animalID.ToString(),
            name,
            ageInt.ToString(),
            gender,
            ToString()
        };

        public override string ToString()
        {
            return $"";
        }
        #endregion
    }
}