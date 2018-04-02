namespace Csharp2_assignment
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.lstGender = new System.Windows.Forms.ListBox();
            this.lstAnimalCategory = new System.Windows.Forms.ListBox();
            this.lblAnimalCategory = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.gbxAnimalCategory = new System.Windows.Forms.GroupBox();
            this.lstSpecies = new System.Windows.Forms.ListBox();
            this.txtAnimalCatInfo = new System.Windows.Forms.TextBox();
            this.lblAnimalCatInfo = new System.Windows.Forms.Label();
            this.gbxSpecies = new System.Windows.Forms.GroupBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.txtSpeciesInfo = new System.Windows.Forms.TextBox();
            this.lblSpeciesInfo = new System.Windows.Forms.Label();
            this.btnDeleteAnimal = new System.Windows.Forms.Button();
            this.lvAnimals = new System.Windows.Forms.ListView();
            this.gbxFeedingSchedule = new System.Windows.Forms.GroupBox();
            this.lbxFoodSchedule = new System.Windows.Forms.ListBox();
            this.tbxEaterType = new System.Windows.Forms.TextBox();
            this.lblEaterType = new System.Windows.Forms.Label();
            this.btnSortSpecies = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            this.btnRecipes = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExportXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileImportXML = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAltXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveBinFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveXMLFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openXMLFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.gbxAnimalCategory.SuspendLayout();
            this.gbxSpecies.SuspendLayout();
            this.gbxFeedingSchedule.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPop);
            this.groupBox1.Controls.Add(this.lstGender);
            this.groupBox1.Controls.Add(this.lstAnimalCategory);
            this.groupBox1.Controls.Add(this.lblAnimalCategory);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Specifications";
            // 
            // btnPop
            // 
            this.btnPop.BackColor = System.Drawing.Color.Lime;
            this.btnPop.Location = new System.Drawing.Point(455, 105);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(52, 17);
            this.btnPop.TabIndex = 9;
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // lstGender
            // 
            this.lstGender.FormattingEnabled = true;
            this.lstGender.ItemHeight = 16;
            this.lstGender.Location = new System.Drawing.Point(220, 61);
            this.lstGender.Name = "lstGender";
            this.lstGender.Size = new System.Drawing.Size(94, 52);
            this.lstGender.TabIndex = 8;
            // 
            // lstAnimalCategory
            // 
            this.lstAnimalCategory.FormattingEnabled = true;
            this.lstAnimalCategory.ItemHeight = 16;
            this.lstAnimalCategory.Location = new System.Drawing.Point(337, 43);
            this.lstAnimalCategory.Name = "lstAnimalCategory";
            this.lstAnimalCategory.Size = new System.Drawing.Size(171, 52);
            this.lstAnimalCategory.TabIndex = 7;
            this.lstAnimalCategory.SelectedIndexChanged += new System.EventHandler(this.lstAnimalCategory_SelectedIndexChanged);
            // 
            // lblAnimalCategory
            // 
            this.lblAnimalCategory.AutoSize = true;
            this.lblAnimalCategory.Location = new System.Drawing.Point(339, 18);
            this.lblAnimalCategory.Name = "lblAnimalCategory";
            this.lblAnimalCategory.Size = new System.Drawing.Size(111, 17);
            this.lblAnimalCategory.TabIndex = 6;
            this.lblAnimalCategory.Text = "Animal Category";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(158, 64);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(66, 61);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(37, 22);
            this.txtAge.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(15, 61);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 17);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(13, 16);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(104, 17);
            this.lblSpecies.TabIndex = 7;
            this.lblSpecies.Text = "Animal Species";
            // 
            // gbxAnimalCategory
            // 
            this.gbxAnimalCategory.Controls.Add(this.lstSpecies);
            this.gbxAnimalCategory.Controls.Add(this.txtAnimalCatInfo);
            this.gbxAnimalCategory.Controls.Add(this.lblAnimalCatInfo);
            this.gbxAnimalCategory.Controls.Add(this.lblSpecies);
            this.gbxAnimalCategory.Location = new System.Drawing.Point(12, 168);
            this.gbxAnimalCategory.Name = "gbxAnimalCategory";
            this.gbxAnimalCategory.Size = new System.Drawing.Size(539, 114);
            this.gbxAnimalCategory.TabIndex = 1;
            this.gbxAnimalCategory.TabStop = false;
            // 
            // lstSpecies
            // 
            this.lstSpecies.FormattingEnabled = true;
            this.lstSpecies.ItemHeight = 16;
            this.lstSpecies.Location = new System.Drawing.Point(16, 38);
            this.lstSpecies.Name = "lstSpecies";
            this.lstSpecies.Size = new System.Drawing.Size(175, 68);
            this.lstSpecies.TabIndex = 12;
            this.lstSpecies.SelectedIndexChanged += new System.EventHandler(this.lstSpecies_SelectedIndexChanged);
            // 
            // txtAnimalCatInfo
            // 
            this.txtAnimalCatInfo.Location = new System.Drawing.Point(251, 82);
            this.txtAnimalCatInfo.Name = "txtAnimalCatInfo";
            this.txtAnimalCatInfo.Size = new System.Drawing.Size(272, 22);
            this.txtAnimalCatInfo.TabIndex = 11;
            // 
            // lblAnimalCatInfo
            // 
            this.lblAnimalCatInfo.AutoSize = true;
            this.lblAnimalCatInfo.Location = new System.Drawing.Point(248, 58);
            this.lblAnimalCatInfo.Name = "lblAnimalCatInfo";
            this.lblAnimalCatInfo.Size = new System.Drawing.Size(38, 17);
            this.lblAnimalCatInfo.TabIndex = 10;
            this.lblAnimalCatInfo.Text = "label";
            // 
            // gbxSpecies
            // 
            this.gbxSpecies.Controls.Add(this.btnAddAnimal);
            this.gbxSpecies.Controls.Add(this.txtSpeciesInfo);
            this.gbxSpecies.Controls.Add(this.lblSpeciesInfo);
            this.gbxSpecies.Location = new System.Drawing.Point(12, 288);
            this.gbxSpecies.Name = "gbxSpecies";
            this.gbxSpecies.Size = new System.Drawing.Size(539, 76);
            this.gbxSpecies.TabIndex = 2;
            this.gbxSpecies.TabStop = false;
            this.gbxSpecies.Text = "   ";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddAnimal.Location = new System.Drawing.Point(438, 21);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(95, 46);
            this.btnAddAnimal.TabIndex = 14;
            this.btnAddAnimal.Text = "Add animal";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // txtSpeciesInfo
            // 
            this.txtSpeciesInfo.Location = new System.Drawing.Point(16, 48);
            this.txtSpeciesInfo.Name = "txtSpeciesInfo";
            this.txtSpeciesInfo.Size = new System.Drawing.Size(286, 22);
            this.txtSpeciesInfo.TabIndex = 13;
            // 
            // lblSpeciesInfo
            // 
            this.lblSpeciesInfo.AutoSize = true;
            this.lblSpeciesInfo.Location = new System.Drawing.Point(13, 22);
            this.lblSpeciesInfo.Name = "lblSpeciesInfo";
            this.lblSpeciesInfo.Size = new System.Drawing.Size(38, 17);
            this.lblSpeciesInfo.TabIndex = 12;
            this.lblSpeciesInfo.Text = "label";
            // 
            // btnDeleteAnimal
            // 
            this.btnDeleteAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteAnimal.Location = new System.Drawing.Point(450, 370);
            this.btnDeleteAnimal.Name = "btnDeleteAnimal";
            this.btnDeleteAnimal.Size = new System.Drawing.Size(95, 46);
            this.btnDeleteAnimal.TabIndex = 15;
            this.btnDeleteAnimal.Text = "Delete animal";
            this.btnDeleteAnimal.UseVisualStyleBackColor = false;
            this.btnDeleteAnimal.Click += new System.EventHandler(this.btnDeleteAnimal_Click);
            // 
            // lvAnimals
            // 
            this.lvAnimals.FullRowSelect = true;
            this.lvAnimals.GridLines = true;
            this.lvAnimals.Location = new System.Drawing.Point(11, 425);
            this.lvAnimals.MultiSelect = false;
            this.lvAnimals.Name = "lvAnimals";
            this.lvAnimals.Size = new System.Drawing.Size(922, 174);
            this.lvAnimals.TabIndex = 3;
            this.lvAnimals.TabStop = false;
            this.lvAnimals.UseCompatibleStateImageBehavior = false;
            this.lvAnimals.View = System.Windows.Forms.View.Details;
            this.lvAnimals.SelectedIndexChanged += new System.EventHandler(this.lvAnimals_SelectedIndexChanged);
            // 
            // gbxFeedingSchedule
            // 
            this.gbxFeedingSchedule.Controls.Add(this.lbxFoodSchedule);
            this.gbxFeedingSchedule.Controls.Add(this.tbxEaterType);
            this.gbxFeedingSchedule.Controls.Add(this.lblEaterType);
            this.gbxFeedingSchedule.Location = new System.Drawing.Point(566, 46);
            this.gbxFeedingSchedule.Name = "gbxFeedingSchedule";
            this.gbxFeedingSchedule.Size = new System.Drawing.Size(367, 318);
            this.gbxFeedingSchedule.TabIndex = 4;
            this.gbxFeedingSchedule.TabStop = false;
            this.gbxFeedingSchedule.Text = "Feeding Schedule";
            // 
            // lbxFoodSchedule
            // 
            this.lbxFoodSchedule.FormattingEnabled = true;
            this.lbxFoodSchedule.ItemHeight = 16;
            this.lbxFoodSchedule.Location = new System.Drawing.Point(16, 77);
            this.lbxFoodSchedule.Name = "lbxFoodSchedule";
            this.lbxFoodSchedule.Size = new System.Drawing.Size(319, 212);
            this.lbxFoodSchedule.TabIndex = 2;
            // 
            // tbxEaterType
            // 
            this.tbxEaterType.Location = new System.Drawing.Point(140, 37);
            this.tbxEaterType.Name = "tbxEaterType";
            this.tbxEaterType.Size = new System.Drawing.Size(196, 22);
            this.tbxEaterType.TabIndex = 1;
            // 
            // lblEaterType
            // 
            this.lblEaterType.AutoSize = true;
            this.lblEaterType.Location = new System.Drawing.Point(21, 36);
            this.lblEaterType.Name = "lblEaterType";
            this.lblEaterType.Size = new System.Drawing.Size(78, 17);
            this.lblEaterType.TabIndex = 0;
            this.lblEaterType.Text = "Eater Type";
            // 
            // btnSortSpecies
            // 
            this.btnSortSpecies.Location = new System.Drawing.Point(22, 374);
            this.btnSortSpecies.Name = "btnSortSpecies";
            this.btnSortSpecies.Size = new System.Drawing.Size(77, 27);
            this.btnSortSpecies.TabIndex = 5;
            this.btnSortSpecies.Text = "Sort";
            this.btnSortSpecies.UseVisualStyleBackColor = true;
            this.btnSortSpecies.Click += new System.EventHandler(this.btnSortSpecies_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(188, 374);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(77, 27);
            this.btnSortName.TabIndex = 6;
            this.btnSortName.Text = "Sort";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // btnID
            // 
            this.btnID.Location = new System.Drawing.Point(105, 374);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(77, 27);
            this.btnID.TabIndex = 7;
            this.btnID.Text = "Sort";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnRecipes
            // 
            this.btnRecipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRecipes.Location = new System.Drawing.Point(706, 370);
            this.btnRecipes.Name = "btnRecipes";
            this.btnRecipes.Size = new System.Drawing.Size(95, 46);
            this.btnRecipes.TabIndex = 15;
            this.btnRecipes.Text = "Recipes";
            this.btnRecipes.UseVisualStyleBackColor = false;
            this.btnRecipes.Click += new System.EventHandler(this.btnRecipes_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStaff.Location = new System.Drawing.Point(829, 370);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(95, 46);
            this.btnStaff.TabIndex = 16;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1506, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.xMLToolStripMenuItem,
            this.exitAltXToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Size = new System.Drawing.Size(181, 26);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(181, 26);
            this.mnuFileOpen.Text = "Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(181, 26);
            this.mnuFileSave.Text = "Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(181, 26);
            this.mnuFileSaveAs.Text = "Save as...";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExportXML,
            this.mnuFileImportXML});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // mnuFileExportXML
            // 
            this.mnuFileExportXML.Name = "mnuFileExportXML";
            this.mnuFileExportXML.Size = new System.Drawing.Size(223, 26);
            this.mnuFileExportXML.Text = "Export to XML file";
            this.mnuFileExportXML.Click += new System.EventHandler(this.mnuFileExportXML_Click);
            // 
            // mnuFileImportXML
            // 
            this.mnuFileImportXML.Name = "mnuFileImportXML";
            this.mnuFileImportXML.Size = new System.Drawing.Size(223, 26);
            this.mnuFileImportXML.Text = "Import from XML file";
            this.mnuFileImportXML.Click += new System.EventHandler(this.mnuFileImportXML_Click);
            // 
            // exitAltXToolStripMenuItem
            // 
            this.exitAltXToolStripMenuItem.Name = "exitAltXToolStripMenuItem";
            this.exitAltXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitAltXToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitAltXToolStripMenuItem.Text = "Exit";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Binary file|*.bin|All files|*.*";
            // 
            // saveBinFileDialog
            // 
            this.saveBinFileDialog.Filter = "Binary file|*.bin";
            // 
            // saveXMLFileDialog
            // 
            this.saveXMLFileDialog.Filter = "XML file|*.xml";
            // 
            // openXMLFileDialog
            // 
            this.openXMLFileDialog.FileName = "openXMLFileDialog";
            this.openXMLFileDialog.Filter = "XML file|*.xml|All files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 664);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnRecipes);
            this.Controls.Add(this.btnDeleteAnimal);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.btnSortSpecies);
            this.Controls.Add(this.gbxFeedingSchedule);
            this.Controls.Add(this.lvAnimals);
            this.Controls.Add(this.gbxSpecies);
            this.Controls.Add(this.gbxAnimalCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Apu\'s Animal Motel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxAnimalCategory.ResumeLayout(false);
            this.gbxAnimalCategory.PerformLayout();
            this.gbxSpecies.ResumeLayout(false);
            this.gbxSpecies.PerformLayout();
            this.gbxFeedingSchedule.ResumeLayout(false);
            this.gbxFeedingSchedule.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblAnimalCategory;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox gbxAnimalCategory;
        private System.Windows.Forms.TextBox txtAnimalCatInfo;
        private System.Windows.Forms.Label lblAnimalCatInfo;
        private System.Windows.Forms.GroupBox gbxSpecies;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.TextBox txtSpeciesInfo;
        private System.Windows.Forms.Label lblSpeciesInfo;
        private System.Windows.Forms.ListBox lstAnimalCategory;
        private System.Windows.Forms.ListBox lstSpecies;
        private System.Windows.Forms.ListBox lstGender;
        private System.Windows.Forms.ListView lvAnimals;
        private System.Windows.Forms.GroupBox gbxFeedingSchedule;
        private System.Windows.Forms.TextBox tbxEaterType;
        private System.Windows.Forms.Label lblEaterType;
        private System.Windows.Forms.ListBox lbxFoodSchedule;
        private System.Windows.Forms.Button btnSortSpecies;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnDeleteAnimal;
        private System.Windows.Forms.Button btnRecipes;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAltXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExportXML;
        private System.Windows.Forms.ToolStripMenuItem mnuFileImportXML;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveBinFileDialog;
        private System.Windows.Forms.SaveFileDialog saveXMLFileDialog;
        private System.Windows.Forms.OpenFileDialog openXMLFileDialog;
    }
}

