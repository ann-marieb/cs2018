/// Falcon.cs
/// Ann-Marie Bergström  ai2436 2018-02-18

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    public class Falcon : Bird
    {
        private string flyingSpeed;

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
        /// <param name="flyingSpeed"></param>
        public Falcon(int animalID, string name, int ageInt, string gender, string wingSpan, string flyingSpeed)
            : base(animalID, name, ageInt, gender, wingSpan)
        {
            this.flyingSpeed = flyingSpeed;
            species = "falcon";
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"> Falcon to be copied.</param>
        public Falcon(Falcon other) : base(other)
        {
            this.flyingSpeed = other.flyingSpeed;
        }

        /// <summary>
        /// Clone this animal. 
        /// </summary>
        /// <returns>a copy of this animal</returns>
        public override IAnimal Clone()
        {
            return new Falcon(this);
        }

        /// <summary>
        /// Returns the eater type of this animal.
        /// </summary>
        /// <returns>the eater type of this animal</returns>
        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Flying Speed {flyingSpeed} km/h. ";
        }

        //public override List<string> GetFoodSchedule()
        //{
        //    // Add feeding items to the list.
        //    feedDescriptionList.Add("Morning: Rabbit");

        //    return feedDescriptionList;
        //}
    }
}