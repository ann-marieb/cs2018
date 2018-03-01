/// Dog.cs
/// Ann-Marie Bergström  ai2436 2018-02-13

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace Csharp2_assignment
{
    public class Dog : Mammal
    {
        private string breed;

        // Create a list of feeding items.
        //List<string> feedDescriptionList = new List<string>() {"Morning: bones", "Midday: Dog food", "Evening: Sweets"};

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="animalID"></param>
        /// <param name="name"></param>
        /// <param name="ageInt"></param>
        /// <param name="gender"></param>
        /// <param name="noOfTeeth"></param>
        /// <param name="breed"></param>
        public Dog(int animalID, string name, int ageInt, string gender, string noOfTeeth, string breed) 
            : base (animalID, name, ageInt, gender, noOfTeeth)
        {
            this.breed = breed;
            foodScheduleObj = new FoodSchedule (new List<string>() { "Morning: bones", "Midday: Dog food", "Evening: Sweets"});
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"> Bear to be copied.</param>
        public Dog(Dog other) : base(other)
        {
            this.breed = other.breed;
        }

        /// <summary>
        /// Clone this animal. 
        /// </summary>
        /// <returns>a copy of this animal</returns>
        public override IAnimal Clone()
        {
            return new Dog(this);
        }

        public override string ToString()
        {
            return $"{base.ToString()} Breed {breed}. ";
        }

    }
}