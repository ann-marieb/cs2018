/// Animal.cs
/// Ann-Marie Bergström  ai2436 2018-02-13

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment1
{
    class Animal
    {
        #region Fields
        private int animalID;
        private string name;
        private int ageInt;
        private string gender;
        protected string species;
        #endregion

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
        }

        /// <summary>
        /// Strings used to fill a row in a ListView.
        /// </summary>
        public string[] RowStrings => new[]
        {
            species,
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
    }
}