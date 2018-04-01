/// FoodSchedule.cs
/// Ann-Marie Bergström  ai2436 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp2_assignment
{
    public class FoodSchedule
    {

        private List<string> feedDescriptionList; // Create a list of feeding items.

        /// <summary>
        /// constructor
        /// </summary>
        public FoodSchedule(List<string> fList)
        {
            feedDescriptionList = new List<string>(fList); //copy list
        }

        /// <summary>
        /// Return feedDescriptionList
        /// </summary>
        public List<string> ToStringList()
        {
            return new List<string>(feedDescriptionList);
        }
    }
}
