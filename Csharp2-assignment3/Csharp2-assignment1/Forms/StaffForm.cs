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

        /// <summary>
        /// default constructor
        /// </summary>
        public StaffForm()
        {
            InitializeComponent();
            if (staffObj == null) staffObj = new Staff();
            InitializeGui();
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
            lstQualifications.Items.Clear(); //clear ingredients list before writing new list
            lstQualifications.Items.AddRange(staffObj.ToStringArray()); //write qualifications list

            tbxQualification.Clear(); // Clear ingredient textbox to enable new input
            tbxQualification.Focus(); //cursor back to ingredient textbox
        }

        /// <summary>
        /// Update GUI staff list
        /// </summary>
        private void UpdateStaffList()
        {
            lbxStaff.Items.Clear();
            //lbxStaff.Items.AddRange(recipeManagerObj.ToStringArray());
        }
        #endregion

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

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxStaffName.Text))
            {
                MessageBox.Show("No name!");
                return;
            }
            staffObj.StaffName = tbxStaffName.Text.Trim();
            //recipeManagerObj.AddItem(recipeObj);
            InitializeGui();
            //lbxStaff.Items.AddRange(recipeManagerObj.ToStringArray());
            staffObj = new Staff(); //create new staffObj as type Staff
        }
    }
}
