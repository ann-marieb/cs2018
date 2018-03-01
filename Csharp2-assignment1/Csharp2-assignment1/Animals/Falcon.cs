/// Falcon.cs
/// Ann-Marie Bergström  ai2436 2018-02-18

namespace Csharp2_assignment1
{
    class Falcon : Bird
    {
        private string flyingSpeed;

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

        public override string ToString()
        {
            return $"{base.ToString()} Flying Speed {flyingSpeed} km/h. ";
        }
    }
}