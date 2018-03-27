/// Dog.cs
/// Ann-Marie Bergström  ai2436 2018

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
            foodScheduleObj = new FoodSchedule(new List<string>() { "Morning: bones", "Midday: Dog food", "Evening: Sweets" });
            //create food schedule object and fill with items specific for this animal
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
        /// Copy this animal. 
        /// </summary>
        public override IAnimal CopyAnimal()
        {
            return new Dog(this);
        }

        /// <summary>
        /// Returns the eater type of this animal.
        /// </summary>
        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Breed {breed}. ";
        }
    }
}