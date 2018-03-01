/// Dog.cs
/// Ann-Marie Bergström  ai2436 2018-02-13

namespace Csharp2_assignment1
{
    class Dog : Mammal
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
            species = "dog";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Breed {breed}. ";
        }
    }
}