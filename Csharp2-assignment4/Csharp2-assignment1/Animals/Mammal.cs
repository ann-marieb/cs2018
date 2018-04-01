/// Mammal.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    public abstract class Mammal : Animal
    {
        private string noOfTeeth;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ageInt"></param>
        /// <param name="gender"></param>
        /// <param name="noOfTeeth"></param>
        public Mammal(string name, int ageInt, string gender, string noOfTeeth) 
            : base(name, ageInt, gender)
        {
            this.noOfTeeth = noOfTeeth;
        }

        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="other"></param>
        public Mammal(Mammal other) : base(other)
        {
            this.noOfTeeth = other.noOfTeeth;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()} Has {noOfTeeth} teeth. ";
        }
    }
}
