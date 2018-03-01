/// Cat.cs
/// Ann-Marie Bergström  ai2436 2018-02-15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    public class Cat : Mammal
    {
        private string colour;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="animalID"></param>
        /// <param name="name"></param>
        /// <param name="ageInt"></param>
        /// <param name="gender"></param>
        /// <param name="noOfTeeth"></param>
        /// <param name="colour"></param>
        public Cat(int animalID, string name, int ageInt, string gender, string noOfTeeth, string colour) 
            : base (animalID, name, ageInt, gender, noOfTeeth)
        {
            this.colour = colour;
            foodScheduleObj = new FoodSchedule(new List<string>() { "Morning: Cat food", "Midday: Mouse", "Evening: Milk" });
        }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"> Cat to be copied.</param>
        public Cat(Cat other) : base(other)
        {
            this.colour = other.colour;
        }

        /// <summary>
        /// Clone this animal. 
        /// </summary>
        /// <returns>a copy of this animal</returns>
        public override IAnimal Clone()
        {
            return new Cat(this);
        }

        public override string ToString()
        {
            return $"{base.ToString()} Colour {colour}. ";
        }
    }
}