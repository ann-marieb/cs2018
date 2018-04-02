/// Dog.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace Csharp2_assignment
{
    [Serializable]
    public class Dog : Mammal
    {
        private string breed;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ageInt"></param>
        /// <param name="gender"></param>
        /// <param name="noOfTeeth"></param>
        /// <param name="breed"></param>
        public Dog(string name, int ageInt, string gender, string noOfTeeth, string breed) 
            : base (name, ageInt, gender, noOfTeeth)
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
            return $"{base.ToString()} Breed {breed}. ";
        }
    }
}