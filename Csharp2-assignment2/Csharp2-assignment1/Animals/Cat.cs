﻿/// Cat.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    public class Cat : Mammal
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
            foodScheduleObj = new FoodSchedule(new List<string>() { "Morning: Cat food", "Midday: Mouse", "Evening: Milk" });
            //create food schedule object and fill with items specific for this animal
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"> Cat to be copied.</param>
        public Cat(Cat other) : base(other)
        {
            this.colour = other.colour;
        }

        /// <summary>
        /// Copy this animal. 
        /// </summary>
        public override IAnimal CopyAnimal()
        {
            return new Cat(this);
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
            return $"{base.ToString()} Colour {colour}. ";
        }
    }
}