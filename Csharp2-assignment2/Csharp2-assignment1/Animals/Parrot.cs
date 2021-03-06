﻿/// Parrot.cs
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
            foodScheduleObj = new FoodSchedule(new List<string>() { "Morning: Refill bird feeder" });
            //create food schedule object and fill with items specific for this animal
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
        /// Copy this animal. 
        /// </summary>
        public override IAnimal CopyAnimal()
        {
            return new Parrot(this);
        }

        /// <summary>
        /// Returns the eater type of this animal.
        /// </summary>
        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Colour {colour}. ";
        }
    }
}