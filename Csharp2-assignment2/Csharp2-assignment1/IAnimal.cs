/// IAnimal.cs
/// Ann-Marie Bergström  ai2436 2018-02-25

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    public interface IAnimal
    {
        /// <summary>
        /// Strings used to fill a row in a ListView.
        /// </summary>
        string[] RowStrings { get; }

        /// <summary>
        /// Make a clone of this animal. The clone has the same ID number.
        /// </summary>
        /// <returns>A copy of the original animal, with the same ID number</returns>
        IAnimal Clone();

        /// <summary>
        /// The animal's eater type.
        /// </summary>
        /// <returns>the eater type of the animal</returns>
        EaterType GetEaterType();

        /// <summary>
        /// The food schedule of the animal
        /// </summary>
        List <string> GetFoodSchedule();


    }
}
