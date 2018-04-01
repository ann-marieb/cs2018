namespace Csharp2_assignment
{
    partial class StaffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbxQualifications = new System.Windows.Forms.GroupBox();
            this.lstQualifications = new System.Windows.Forms.ListBox();
            this.btnAddQual = new System.Windows.Forms.Button();
            this.tbxQualification = new System.Windows.Forms.TextBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.tbxStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lbxStaff = new System.Windows.Forms.ListBox();
            this.btnCloseStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.toolTipQualification = new System.Windows.Forms.ToolTip(this.components);
            this.gbxQualifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxQualifications
            // 
            this.gbxQualifications.Controls.Add(this.lstQualifications);
            this.gbxQualifications.Controls.Add(this.btnAddQual);
            this.gbxQualifications.Controls.Add(this.tbxQualification);
            this.gbxQualifications.Controls.Add(this.lblIngredient);
            this.gbxQualifications.Location = new System.Drawing.Point(47, 90);
            this.gbxQualifications.Name = "gbxQualifications";
            this.gbxQualifications.Size = new System.Drawing.Size(539, 253);
            this.gbxQualifications.TabIndex = 12;
            this.gbxQualifications.TabStop = false;
            this.gbxQualifications.Text = "Qualifications";
            // 
            // lstQualifications
            // 
            this.lstQualifications.FormattingEnabled = true;
            this.lstQualifications.ItemHeight = 16;
            this.lstQualifications.Location = new System.Drawing.Point(153, 88);
            this.lstQualifications.Name = "lstQualifications";
            this.lstQualifications.Size = new System.Drawing.Size(347, 148);
            this.lstQualifications.TabIndex = 13;
            // 
            // btnAddQual
            // 
            this.btnAddQual.Location = new System.Drawing.Point(29, 89);
            this.btnAddQual.Name = "btnAddQual";
            this.btnAddQual.Size = new System.Drawing.Size(81, 33);
            this.btnAddQual.TabIndex = 2;
            this.btnAddQual.Text = "Add";
            this.btnAddQual.UseVisualStyleBackColor = true;
            this.btnAddQual.Click += new System.EventHandler(this.btnAddQual_Click);
            // 
            // tbxQualification
            // 
            this.tbxQualification.Location = new System.Drawing.Point(146, 38);
            this.tbxQualification.Name = "tbxQualification";
            this.tbxQualification.Size = new System.Drawing.Size(355, 22);
            this.tbxQualification.TabIndex = 1;
            this.tbxQualification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQualification_KeyPress);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(26, 41);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(86, 17);
            this.lblIngredient.TabIndex = 0;
            this.lblIngredient.Text = "Qualification";
            // 
            // tbxStaffName
            // 
            this.tbxStaffName.Location = new System.Drawing.Point(159, 41);
            this.tbxStaffName.Name = "tbxStaffName";
            this.tbxStaffName.Size = new System.Drawing.Size(428, 22);
            this.tbxStaffName.TabIndex = 11;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(39, 38);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(76, 17);
            this.lblStaffName.TabIndex = 10;
            this.lblStaffName.Text = "Staff name";
            // 
            // lbxStaff
            // 
            this.lbxStaff.FormattingEnabled = true;
            this.lbxStaff.ItemHeight = 16;
            this.lbxStaff.Location = new System.Drawing.Point(615, 45);
            this.lbxStaff.Name = "lbxStaff";
            this.lbxStaff.Size = new System.Drawing.Size(511, 340);
            this.lbxStaff.TabIndex = 15;
            // 
            // btnCloseStaff
            // 
            this.btnCloseStaff.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseStaff.Location = new System.Drawing.Point(244, 358);
            this.btnCloseStaff.Name = "btnCloseStaff";
            this.btnCloseStaff.Size = new System.Drawing.Size(157, 43);
            this.btnCloseStaff.TabIndex = 14;
            this.btnCloseStaff.Text = "Close";
            this.btnCloseStaff.UseVisualStyleBackColor = true;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(76, 358);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(157, 43);
            this.btnAddStaff.TabIndex = 13;
            this.btnAddStaff.Text = "Add staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 448);
            this.Controls.Add(this.gbxQualifications);
            this.Controls.Add(this.tbxStaffName);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lbxStaff);
            this.Controls.Add(this.btnCloseStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Name = "StaffForm";
            this.Text = "Staff";
            this.gbxQualifications.ResumeLayout(false);
            this.gbxQualifications.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxQualifications;
        private System.Windows.Forms.ListBox lstQualifications;
        private System.Windows.Forms.Button btnAddQual;
        private System.Windows.Forms.TextBox tbxQualification;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.TextBox tbxStaffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.ListBox lbxStaff;
        private System.Windows.Forms.Button btnCloseStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.ToolTip toolTipQualification;
    }
}