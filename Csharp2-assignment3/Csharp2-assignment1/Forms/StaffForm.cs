/// StaffForm.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp2_assignment
{
    public partial class StaffForm : Form
    {
        private Staff staffObj;
        private ListManager<Staff> staffListObj; //declare received staffListObj

        /// <summary>
        /// default constructor
        /// </summary>
        public StaffForm()
        {
            InitializeComponent();
            if (staffObj == null) staffObj = new Staff();
            InitializeGui();
        }

        /// <summary>
        /// property for access to staffList
        /// </summary>
        public ListManager<Staff> StaffList
        {
            get => staffListObj;
            set
            {
                staffListObj = value; //value = staffListObj from Mainform
                UpdateStaffList(); // display staff list if there is one 
            }
        }
        
        #region user interface methods
        /// <summary>
        /// initialize user interface
        /// </summary>
        private void InitializeGui()
        {
            tbxStaffName.Clear(); // clear textbox    
            lstQualifications.Items.Clear(); // clear qualifications list
            lbxStaff.Items.Clear(); // clear staff list
            toolTipQualification.SetToolTip(tbxQualification, "Example: lion tamer"); //set tool tip at qualifications textbox
        }

        /// <summary>
        /// update GUI qualifications list
        /// </summary>
        private void UpdateQualificationsList()
        {
            lstQualifications.Items.Clear(); //clear qualifications list before writing new list
            lstQualifications.Items.AddRange(staffObj.ToStringArray()); //write qualifications list

            tbxQualification.Clear(); // Clear qualifications textbox to enable new input
            tbxQualification.Focus(); //cursor back to qualifications textbox
        }

        /// <summary>
        /// Update GUI staff list
        /// </summary>
        private void UpdateStaffList()
        {
            lbxStaff.Items.Clear();
            lbxStaff.Items.AddRange(staffListObj.ToStringArray());
        }
        #endregion

        #region button methods

        /// <summary>
        /// add qualification to qualifications list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddQual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxQualification.Text))
            {
                MessageBox.Show("No qualification!");
                return;
            }
            staffObj.AddQualification(tbxQualification.Text.Trim());
            UpdateQualificationsList();
        }

        /// <summary>
        /// Enter key instead of click Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxQualification_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnAddQual_Click(sender, e);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Add staff to staff list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxStaffName.Text))
            {
                MessageBox.Show("No name!");
                return;
            }
            staffObj.StaffName = tbxStaffName.Text.Trim();
            staffListObj.AddItem(staffObj); //add staff to staff lsit
            InitializeGui();
            UpdateStaffList();
            staffObj = new Staff(); //create new staffObj as type Staff
        }
        #endregion
    }
}
