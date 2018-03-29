/// Staff.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    class Staff
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

        public string StaffName
        {
            get { return staffName; }
            set
            {
                staffName = value;
            }
        }

        /// <summary>
        /// return qualifications list as string array
        /// </summary>
        public string[] ToStringArray()
        {
            return qualificationsList.ToStringArray();
        }

        internal void AddQualification(string item)
        {
            qualificationsList.AddItem(item);
        }
    }
}
