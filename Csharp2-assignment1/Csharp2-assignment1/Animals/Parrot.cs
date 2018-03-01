/// Parrot.cs
/// Ann-Marie Bergström  ai2436 2018-02-18

namespace Csharp2_assignment1
{
    class Parrot : Bird
    {
        private string colour;

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

        public override string ToString()
        {
            return $"{base.ToString()} Colour {colour}. ";
        }
    }
}