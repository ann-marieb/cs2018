/// Mammal.cs
/// Ann-Marie Bergström  ai2436 2018-02-13

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment1
{
    class Mammal : Animal
    {
        private string noOfTeeth;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="newID"></param>
        /// <param name="name"></param>
        /// <param name="ageInt"></param>
        /// <param name="gender"></param>
        /// <param name="noOfTeeth"></param>
        public Mammal(int newID, string name, int ageInt, string gender, string noOfTeeth) 
            : base(newID, name, ageInt, gender)
        {
            this.noOfTeeth = noOfTeeth;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Has {noOfTeeth} teeth. ";
        }
    }
}
