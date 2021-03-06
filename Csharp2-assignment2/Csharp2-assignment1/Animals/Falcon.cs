﻿/// Falcon.cs
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

        public override string ToString()
        {
            return $"{base.ToString()} Flying Speed {flyingSpeed} km/h. ";
        }

    }
}