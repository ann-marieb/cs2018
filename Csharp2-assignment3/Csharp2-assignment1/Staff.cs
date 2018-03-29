/// Staff.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    public class Staff
    {
        private string staffName;
        private IListManager<string> qualificationsList;

        /// <summary>
        /// default constructor
        /// </summary>
        public Staff ()
        {
            qualificationsList = new ListManager<string>();
        }

        /// <summary>
        /// property
        /// </summary>
        public string StaffName
        {
            get { return staffName; }
            set
            {
                staffName = value;
            }
        }

        /// <summary>
        /// add a qualification to qualifications list
        /// </summary>
        /// <param name="item"></param>
        internal void AddQualification(string item)
        {
            qualificationsList.AddItem(item);
        }

        /// <summary>
        /// return qualifications list as string array
        /// </summary>
        public string[] ToStringArray()
        {
            return qualificationsList.ToStringArray();
        }

        /// <summary>
        /// return a staff as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return StaffName + ": " + string.Join(", ", (ListManager<string>)qualificationsList) + ".";
        }
    }
}
