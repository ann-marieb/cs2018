/// Cat.cs
/// Ann-Marie Bergström  ai2436 2018-02-15

namespace Csharp2_assignment1
{
    class Cat : Mammal
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
            species = "cat";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Colour {colour}. ";
        }
    }
}