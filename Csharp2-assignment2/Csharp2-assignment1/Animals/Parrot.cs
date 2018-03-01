/// Parrot.cs
/// Ann-Marie Bergström  ai2436 2018-02-18

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    class Parrot : Bird
    {
        private string colour;

        // Create a list of feeding items.
        List<string> feedDescriptionList = new List<string>();

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="animalID"></param>
        /// <param name="name"></param>
        /// <param name="ageInt"></param>
        /// <param name="gender"></param>
        /// <param name="wingSpan"></param>
        /// <param name="colour"></param>
        public Parrot(int animalID, string name, int ageInt, string gender, string wingSpan, string colour)
            : base(animalID, name, ageInt, gender, wingSpan)
        {
            this.colour = colour;
            species = "parrot";
        }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other">Copied parrot</param>
        public Parrot(Parrot other) : base(other)
        {
            this.colour = other.colour;
        }

        /// <summary>
        /// Clone this animal. 
        /// </summary>
        /// <returns>a copy of this animal</returns>
        public override IAnimal Clone()
        {
            return new Parrot(this);
        }

        /// <summary>
        /// Returns the eater type of this animal.
        /// </summary>
        /// <returns>the eater type of this animal</returns>
        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Colour {colour}. ";
        }

        //public override List<string> GetFoodSchedule()
        //{
        //    // Add feeding items to the list.
        //    feedDescriptionList.Add("Morning: Refill bird feeder");

        //    return feedDescriptionList;
        //}
    }
}