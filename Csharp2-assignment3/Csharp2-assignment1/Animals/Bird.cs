﻿/// Bird.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    public abstract class Bird : Animal
    {
        private string wingSpan;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ageInt"></param>
        /// <param name="gender"></param>
        /// <param name="wingSpan"></param>
        public Bird(string name, int ageInt, string gender, string wingSpan) 
            : base(name, ageInt, gender)
        {
            this.wingSpan = wingSpan;
        }

        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="other"></param>
        public Bird(Bird other) : base(other)
        {
            this.wingSpan = other.wingSpan;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Wing span {wingSpan} cm. ";
        }
    }
}
