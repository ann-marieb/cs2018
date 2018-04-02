/// Falcon.cs
/// Ann-Marie Bergström  ai2436 2018-02-18

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    [Serializable]
    public class Falcon : Bird
    {
        private string flyingSpeed;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ageInt"></param>
        /// <param name="gender"></param>
        /// <param name="wingSpan"></param>
        /// <param name="flyingSpeed"></param>
        public Falcon(string name, int ageInt, string gender, string wingSpan, string flyingSpeed)
            : base(name, ageInt, gender, wingSpan)
        {
            this.flyingSpeed = flyingSpeed;
            foodScheduleObj = new FoodSchedule(new List<string>() { "Morning: Rabbit" });
            //create food schedule object and fill with items specific for this animal
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
        /// Copy this animal. 
        /// </summary>
        public override IAnimal CopyAnimal()
        {
            return new Falcon(this);
        }

        /// <summary>
        /// Returns the eater type of this animal.
        /// </summary>
        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;
        }


        /// <summary>
        /// Returns feedDescriptionList of the animal.
        /// </summary>
        public override List<string> GetFoodSchedule()
        {
            var fList = foodScheduleObj.ToStringList(); // get feedDescriptionList from FoodSchedule
            return new List<string>(fList);
        }

        public override string ToString()
        {
            return $"{base.ToString()} Flying Speed {flyingSpeed} km/h. ";
        }

    }
}