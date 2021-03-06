﻿namespace Csharp2_assignment1
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
            this.lvAnimals = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.gbxAnimalCategory.SuspendLayout();
            this.gbxSpecies.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstGender);
            this.groupBox1.Controls.Add(this.lstAnimalCategory);
            this.groupBox1.Controls.Add(this.lblAnimalCategory);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Specifications";
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
            this.lblSpecies.Location = new System.Drawing.Point(13, 18);
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
            this.gbxAnimalCategory.Location = new System.Drawing.Point(12, 151);
            this.gbxAnimalCategory.Name = "gbxAnimalCategory";
            this.gbxAnimalCategory.Size = new System.Drawing.Size(539, 121);
            this.gbxAnimalCategory.TabIndex = 1;
            this.gbxAnimalCategory.TabStop = false;
            // 
            // lstSpecies
            // 
            this.lstSpecies.FormattingEnabled = true;
            this.lstSpecies.ItemHeight = 16;
            this.lstSpecies.Location = new System.Drawing.Point(16, 42);
            this.lstSpecies.Name = "lstSpecies";
            this.lstSpecies.Size = new System.Drawing.Size(175, 68);
            this.lstSpecies.TabIndex = 12;
            this.lstSpecies.SelectedIndexChanged += new System.EventHandler(this.lstSpecies_SelectedIndexChanged);
            // 
            // txtAnimalCatInfo
            // 
            this.txtAnimalCatInfo.Location = new System.Drawing.Point(251, 88);
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
            this.gbxSpecies.Location = new System.Drawing.Point(12, 278);
            this.gbxSpecies.Name = "gbxSpecies";
            this.gbxSpecies.Size = new System.Drawing.Size(539, 99);
            this.gbxSpecies.TabIndex = 2;
            this.gbxSpecies.TabStop = false;
            this.gbxSpecies.Text = "   ";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddAnimal.Location = new System.Drawing.Point(428, 33);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(95, 46);
            this.btnAddAnimal.TabIndex = 14;
            this.btnAddAnimal.Text = "Add animal";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // txtSpeciesInfo
            // 
            this.txtSpeciesInfo.Location = new System.Drawing.Point(16, 57);
            this.txtSpeciesInfo.Name = "txtSpeciesInfo";
            this.txtSpeciesInfo.Size = new System.Drawing.Size(286, 22);
            this.txtSpeciesInfo.TabIndex = 13;
            // 
            // lblSpeciesInfo
            // 
            this.lblSpeciesInfo.AutoSize = true;
            this.lblSpeciesInfo.Location = new System.Drawing.Point(13, 31);
            this.lblSpeciesInfo.Name = "lblSpeciesInfo";
            this.lblSpeciesInfo.Size = new System.Drawing.Size(38, 17);
            this.lblSpeciesInfo.TabIndex = 12;
            this.lblSpeciesInfo.Text = "label";
            // 
            // lvAnimals
            // 
            this.lvAnimals.FullRowSelect = true;
            this.lvAnimals.GridLines = true;
            this.lvAnimals.Location = new System.Drawing.Point(12, 383);
            this.lvAnimals.MultiSelect = false;
            this.lvAnimals.Name = "lvAnimals";
            this.lvAnimals.Size = new System.Drawing.Size(922, 227);
            this.lvAnimals.TabIndex = 3;
            this.lvAnimals.TabStop = false;
            this.lvAnimals.UseCompatibleStateImageBehavior = false;
            this.lvAnimals.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 664);
            this.Controls.Add(this.lvAnimals);
            this.Controls.Add(this.gbxSpecies);
            this.Controls.Add(this.gbxAnimalCategory);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Apu\'s Animal Motel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxAnimalCategory.ResumeLayout(false);
            this.gbxAnimalCategory.PerformLayout();
            this.gbxSpecies.ResumeLayout(false);
            this.gbxSpecies.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

