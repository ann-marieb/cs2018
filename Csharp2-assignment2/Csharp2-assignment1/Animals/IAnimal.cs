/// IAnimal.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    public interface IAnimal
    {
        string Name { get; }
        string Species { get; }
        int AnimalID { get; }

        /// <summary>
        /// Make a copy of the animal with the same ID number.
        /// </summary>
        IAnimal CopyAnimal();

        /// <summary>
        /// Return the eater type of the animal.
        /// </summary>
        EaterType GetEaterType();

        /// <summary>
        /// The food schedule of the animal
        /// </summary>
        List <string> GetFoodSchedule();

        /// <summary>
        /// Strings used to fill a row in a ListView.
        /// </summary>
        string[] RowStrings { get; }
    }
}
